package com.example;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

class AppTest {


    @Test
    void testMain() {
        // Redireciona a saída para verificar o que foi impresso
        var outContent = new java.io.ByteArrayOutputStream();
        System.setOut(new java.io.PrintStream(outContent));
        
        // Chama o método main da classe App
        App.main(new String[]{});
        
        // Verifica se a saída é "Hello, World!" seguida de uma nova linha
        assertEquals("Hello, World!", outContent.toString());
    }
}
