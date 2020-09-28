namespace FaculOop.WebApi.Conceitos
{
    /*
    [HttpGet("teste")]
    public IActionResult Teste()
    {
        var pessoa = new Aluno("Tiago", "123456");
        
        return Ok(new {
            nome = pessoa.FalarNome(),
            matricula = pessoa.FalarMatricula()
        });
    }
    */

    class Pessoa
    {
        private readonly string _name;
        public Pessoa(string name)
        {
            _name = name;
        }

        public string FalarNome()
        {
            return _name;
        }
    }

    class Aluno : Pessoa
    {
        private readonly string _registerCode;
        public Aluno(string name, string registerCode) : base(name)
        {
            _registerCode = registerCode;
        }

        public string FalarMatricula()
        {
            return _registerCode;
        }
    }
}