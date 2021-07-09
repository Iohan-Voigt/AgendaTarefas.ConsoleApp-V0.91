using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgendaTarefas.Controlador;
using System.Collections.Generic;
using AgendaTarefas.Tela;
using AgendaTarefas.Dominio;
using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace UnitTestProjectAgenda
{
    [TestClass]
    public class UnitTest1
    {

        ControladorTarefa controladorTarefa = new ControladorTarefa();
        ControladorContatos controladorContatos = new ControladorContatos();
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();

        [TestMethod]
        public void InsercaoDeDadosNoBanco()
        {
            Tarefa tarefa = new Tarefa();
            tarefa.titulo = "titulo exemplo 111";
            tarefa.prioridade = 1;
            tarefa.percentualConclusao = 0;
            tarefa.dataAbertura = Convert.ToDateTime("13/05/2001");
            controladorTarefa.InserirRegistro(tarefa);
            Assert.IsNotNull(controladorTarefa.SelecionarTodosRegistros());           
        }

        [TestMethod]
        public void SelecionarDadosNoBanco()
        {
            List<Tarefa> tarefas = controladorTarefa.SelecionarTodosRegistros();
            Assert.IsNotNull(tarefas);

        }

        [TestMethod]
        public void EditarDadosNoBanco()
        {
            Tarefa tarefa = new Tarefa();
            tarefa.titulo = "titulo exemplo 111";
            tarefa.prioridade = 1;
            tarefa.percentualConclusao = 0;
            tarefa.dataAbertura = Convert.ToDateTime("13/05/2001");

        }
        [TestMethod]
        public void ExcluirDadosNoBanco()
        {


        }
    }
}
