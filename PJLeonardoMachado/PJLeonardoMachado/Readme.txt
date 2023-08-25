
====================== Criar novo Projeto ASP.NET ===========================

1. Abra o Visual Studio;

2. Clique em criar Novo Projeto;

3. Selecione a opção Aplicativo Web do ASP.NET core (Model-View-Controller)

====================== Instalar NuGet Packages ===========================

Ferramentas > 
Gerenciador de Pacotes do NuGet > 
Gerenciar pacotes NuGet para a solução

Esse projeto utiliza a versão 6.0.20 do Net Core, então instale os pacotes nesta versão.

Instalar:

* Microsoft.AspNetCore.Identity.EntityFrameworkCore

* Microsoft.EntityFrameworkCore

* Microsoft.EntityFrameworkCore.Design

* Microsoft.EntityFrameworkCore.SqlServer

====================== Criar classes ===========================

No Gerenciador de Soluções(Crtl + Alt + L), clique com o botão direito do mouse na pasta Models

Selecione Adcionar > Novo Item

Nomeia a classe com Psico.cs

====================== Criando os Objetos e atibutos das Classe ===========================

------ Psico.cs -----------------

public int Id { get; set; }
public string Nome { get; set; }
public string Sobrenome { get; set; }
public string CPF { get; set; }
public string CRM { get; set; }
public string Especialidade { get; set; }


============ Criando o DBContext ======================

Crie a pasta Data 
Dentro dela crie o novo item appDbcontext.cs


========== Definndo parãmetros de configuração no program.cs ================

Abra o program.cs

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<appDbContext>(options =>
   options.UseSqlServer(
       builder.Configuration.GetConnectionString("PsiuContext")
       )
   );
   
============ Criando a migration (initial) e atualizando o banco de dados ==================

Para criar a migration (initial) e atualizar o banco de dados, siga estas etapas:

Abra a janela Gerenciador de Pacotes NuGet.
No campo de pesquisa, digite EF Core Migrations.
Clique no botão Instalar.
No Visual Studio, abra a janela PM Console.
Digite o seguinte comando no Console:

dotnet ef migrations add Initial







