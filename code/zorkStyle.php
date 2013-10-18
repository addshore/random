<?php
$locFormatter = new LocationFormatter();

$map = new Map( 1,2, new Location( 1,1 ) );
$map->addSegment( new Segment( 'start', new Location( 1, 1 ) ) );
$map->addSegment( new Segment( 'end', new Location( 1, 2 ) ) );

$game = new Game( $map );
$player = $game->newPlayer( 'person' );
echo $locFormatter->format( $game->whereIs( $player ) );

class Game{
	/** @var Map */
	protected $map;
	/** @var Player[] */
	protected $players = array();
	function __construct( Map $map ){
		$this->map = $map;
	}
	function newPlayer( $name ){
		if( array_key_exists( $name, $this->players ) ){
			throw new Exception( 'Player already exists' );
		}
		$player = new Player( $name, $this->map->getStartLocation() );
		$this->players[ $player->getName() ] = $player;
		return $player;
	}
	function getPlayer( Player $player ){
		return $this->players[ $player->getName() ];
	}
	function whereIs( Player $player ){
		return $this->getPlayer( $player )->getLocation();
	}
	function moveNorth( Player $player ){
		$this->getPlayer( $player )->getLocation()->moveNorth();
	}
	function moveSouth( Player $player ){
		$this->getPlayer( $player )->getLocation()->moveSouth();
	}
	function moveEast( Player $player ){
		$this->getPlayer( $player )->getLocation()->moveEast();
	}
	function moveWest( Player $player ){
		$this->getPlayer( $player )->getLocation()->moveWest();
	}
}

class Map{

	/** @var Segment[] */
	protected $segments = array();
	protected $x;
	protected $y;
	protected $startLocation;
	protected $nextId = 0;

	function __construct( $x, $y, Location $start ) {
		$this->x = $x;
		$this->y = $y;
		$this->startLocation = $start;
	}

	function getNextId(){
		$this->nextId++;
		return $this->nextId;
	}

	function addSegment( Segment $seg ){
		$id = $this->getNextId();
		$segments[$id] = $seg;
		$segmentsIndex[$seg->getX()][$seg->getY()] = $id;
	}

	function getSegment( Location $loc ){
		return $this->segments[ $loc->getX() ][ $loc->getY() ];
	}
	function getStartLocation(){
		return $this->startLocation;
	}
}

class Segment{
	protected $name;
	protected $loc;
	function __construct( $name, Location $loc ) {
		$this->loc = $loc;
	}
	function getX(){
		return $this->loc->getX();
	}
	function getY(){
		return $this->loc->getY();
	}
}

class Player{
	/** @var string */
 	protected $name;
	/** @var Location */
	protected $loc;
	function __construct( $name, Location $loc ){
		$this->name;
		$this->loc = $loc;
	}
	function getName(){
		return $this->name;
	}
	function getLocation(){
		return $this->loc;
	}
}

class Location{
	protected $x;
	protected $y;
	function __construct( $x, $y ){
		$this->x = $x;
		$this->y = $y;
	}
	function moveNorth(){
		$this->y++;
	}
	function moveSouth(){
		$this->y--;
	}
	function moveEast(){
		$this->x++;
	}
	function moveWest(){
		$this->x--;
	}
	function getX(){
		return $this->x;
	}
	function getY(){
		return $this->y;
	}
}

class LocationFormatter{
	function format( Location $loc ){
		return $loc->getX() . 'X, ' . $loc->getY() . 'Y ';
	}
}