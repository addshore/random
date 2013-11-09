<?php
/**
 * Little script to see how long it would take for random key presses to
 * create a given string.
 */

$searchFor = "add";
$searchIn = "abcdefghijklmnopqrstuvwxyz ";
$randomSearcher = new RandomSearcher( $searchFor, $searchIn );
$result = $randomSearcher->search();
echo $result;

class RandomSearcher {

	private $searchFor;
	private $searchIn;
	private $counter;
	private $currentSearchString;

	public function __construct( $searchFor, $searchIn ){
		$this->counter = 0;
		$this->searchFor = $searchFor;
		$this->searchIn = str_split( $searchIn );
		$this->currentSearchString = '';
	}

	protected function searchForLength(){
		return strlen( $this->searchFor );
	}

	public function search() {
		$found = false;
		while ( !$found ) {
			if( $this->counter === 0 ){
				$this->generateFirstString();
			} else {
				$this->generateNextLetter();
			}
			$this->counter++;
			echo "{$this->currentSearchString}\n";
			if( $this->currentSearchString === $this->searchFor ){
				$found = true;
			}
		}
		return "Found {$this->searchFor} after {$this->counter} tries!";
	}

	private function generateFirstString() {
		$length = $this->searchForLength();
		while( $length > 0 ){
			$this->generateNextLetter();
			$length--;
		}
	}

	private function generateNextLetter() {
		$key = mt_rand( 0, count( $this->searchIn ) - 1 );
		$letter = $this->searchIn[ $key ];
		$this->currentSearchString .= $letter;
		if( strlen( $this->currentSearchString ) > strlen( $this->searchFor ) ){
			$this->currentSearchString = substr( $this->currentSearchString, 1, $this->searchForLength() );
		}
	}
}