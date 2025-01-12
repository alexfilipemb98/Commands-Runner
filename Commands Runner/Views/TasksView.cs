using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commands_Runner.Views
{
    public partial class TasksView : DevExpress.XtraEditors.XtraUserControl
    {
        public TasksView() => InitializeComponent();


        public void DemoData()
        {
            List<TaskModel> tasks = new List<TaskModel>();

            tasks.Add(new TaskModel { Id = 1, Nome = "Comprar mantimentos", Descricao = "Ir ao supermercado e comprar itens da lista.", Status = TaskStatusEnum.Todo });
            tasks.Add(new TaskModel { Id = 2, Nome = "Estudar programação", Descricao = "Revisar conceitos de C# e praticar com exercícios.", Status = TaskStatusEnum.Todo });
            tasks.Add(new TaskModel { Id = 3, Nome = "Reunião com cliente", Descricao = "Discutir requisitos para o novo projeto.", Status = TaskStatusEnum.Todo });
            tasks.Add(new TaskModel { Id = 4, Nome = "Ler livro", Descricao = "Avançar pelo menos 3 capítulos do livro atual.", Status = TaskStatusEnum.Todo });
            tasks.Add(new TaskModel { Id = 5, Nome = "Planejar viagem", Descricao = "Pesquisar hotéis e passagens para a próxima viagem.", Status = TaskStatusEnum.Todo });
            tasks.Add(new TaskModel { Id = 6, Nome = "Manutenção no carro", Descricao = "Levar o carro para revisão no mecânico.", Status = TaskStatusEnum.Todo });
            tasks.Add(new TaskModel { Id = 7, Nome = "Organizar arquivos", Descricao = "Classificar e deletar arquivos antigos no computador.", Status = TaskStatusEnum.Todo });

            tasks.Add(new TaskModel { Id = 8, Nome = "Escrever relatório", Descricao = "Finalizar o relatório semanal de desempenho.", Status = TaskStatusEnum.Doing });
            tasks.Add(new TaskModel { Id = 9, Nome = "Treino na academia", Descricao = "Fazer o treino de força programado para hoje.", Status = TaskStatusEnum.Doing });
            tasks.Add(new TaskModel { Id = 10, Nome = "Atualizar site", Descricao = "Corrigir bugs reportados no site e atualizar conteúdos.", Status = TaskStatusEnum.Doing });
            tasks.Add(new TaskModel { Id = 11, Nome = "Aprender sobre Docker", Descricao = "Assistir a tutoriais e testar criação de containers.", Status = TaskStatusEnum.Doing });

            tasks.Add(new TaskModel { Id = 12, Nome = "Pagar contas", Descricao = "Contas de água, luz e internet já pagas.", Status = TaskStatusEnum.Done });
            tasks.Add(new TaskModel { Id = 13, Nome = "Enviar e-mails", Descricao = "Todos os e-mails importantes foram enviados.", Status = TaskStatusEnum.Done });
            tasks.Add(new TaskModel { Id = 14, Nome = "Organizar agenda", Descricao = "Agenda atualizada para a próxima semana.", Status = TaskStatusEnum.Done });



            gcTaskTodo.DataSource = tasks.Where(w => w.Status == TaskStatusEnum.Todo);
            gcTaskDoing.DataSource = tasks.Where(w => w.Status == TaskStatusEnum.Doing);
            gcTaskDone.DataSource = tasks.Where(w => w.Status == TaskStatusEnum.Done);
        }
    }

    public class TaskModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public TaskStatusEnum Status { get; set; }
    }

    public enum TaskStatusEnum
    {
        Todo,
        Doing,
        Done
    }
}
