<?php
$shortOut = array();
$longOut = array();
//Short
$i = 0;
while( $i++ < 1000 && $s = "\n" ) {
	if( !strstr ( strval ( $i / 3 ), '.' ) ) { $s = 'Fizz'; }
	if( !strstr ( strval ( $i / 5 ), '.' ) ) { $s = 'Buzz'; }
	$shortOut[] = $s == "\n" ? $i : $s;
}

//Long
$i = 0;
while ( $i < 1000 ){
	$output = '';
	$i = $i + 1;
	$fizz = $i / 3;
	$buzz = $i / 5;
	if( !strstr( strval( $fizz ), '.' ) ){
		$output = 'Fizz';
	}
	if( !strstr( strval( $buzz ), '.' ) ){
		$output = 'Buzz';
	}
	if( $output === '' ){
		$longOut[] = $i;
	} else {
		$longOut[] =$output;
	}
}

if( $shortOut !== $longOut ){
	echo "WRONG!\n";
}

foreach( $shortOut as $key => $shortVal ){
	$longVal = $longOut[ $key ];
	echo " {$shortVal}, {$longVal}\n";
}