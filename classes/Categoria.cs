using System;

public class Categoria {
	private int id;
	private String descricao;

	public int GetId() {
		return this.id;
	}
	public void SetId(ref int id) {
		this.id = id;
	}
	public String GetDescricao() {
		return this.descricao;
	}
	public void SetDescricao(ref String descricao) {
		this.descricao = descricao;
	}

}
