using System;
using System.Collections.Generic;
using System.Collections;


public class Postagens
{

    public string Autor { get; set; }
    public string Conteudo { get; set; }

    public Postagens(string conteudo, string autor)
    {
        Autor = autor;
        Conteudo = conteudo;
    }


}