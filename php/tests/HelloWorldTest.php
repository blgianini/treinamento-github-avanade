<?php

use PHPUnit\Framework\TestCase;
use HelloWorld\HelloWorld;

class HelloWorldTest extends TestCase
{
    public function testGreet()
    {
        $helloWorld = new HelloWorld();
        $this->assertEquals("Hello, World!", $helloWorld->main());
    }
}