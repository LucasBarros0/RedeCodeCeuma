using System;
using System.Collections.Generic;
using System.Collections;


public class Usuario
{
    public string NomeUsuario { get; set; }
    public string Senha { get; set; }
    public List<Postagens> Postagens { get; set; }


    public Usuario(string nomeUsuario, string senha)
    {
        NomeUsuario = nomeUsuario;
        Senha = senha;
        Postagens = new List<Postagens>();
    }

    public void AdicionarPostagem(string conteudo)
    {
        Postagens postagens = new Postagens(NomeUsuario, conteudo);
        Postagens.Add(postagens);
    }
}