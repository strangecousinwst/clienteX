using System;

public class Processos {
	private int id;
	private Categoria categoria;
	private Funcionario supervisor;
	private Funcionario funcionario_Responsável;
	private Prioridade prioridade;

	public int GetId() {
		return this.id;
	}
	public void SetId(ref int id) {
		this.id = id;
	}
	public Funcionario GetSupervisor() {
		return this.supervisor;
	}
	public void SetSupervisor(ref Funcionario supervisor) {
		this.supervisor = supervisor;
	}
	public Funcionario GetFuncionario_Responsável() {
		return this.funcionario_Responsável;
	}
	public void SetFuncionario_Responsável(ref Funcionario funcionario_Responsável) {
		this.funcionario_Responsável = funcionario_Responsável;
	}
	public Prioridade GetPrioridade() {
		return this.prioridade;
	}
	public void SetPrioridade(ref Prioridade prioridade) {
		this.prioridade = prioridade;
	}

}
