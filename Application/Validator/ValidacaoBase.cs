//using Application.Interface;


//namespace Application.Validator
//{
//    public abstract class ValidacaoBase : IApplicationValidatorBase
//    {
//        /// <summary>
//        /// Valida se usuario foi encontrado na base de dados;
//        /// true  = O usuário existe;
//        /// false = O usuário não existe;
//        /// 
//        /// </summary>
//        /// <param name="IdUsuario">long?</param>
//        /// <returns>bool</returns>
//        public bool validaUsuarioExistente(long? IdUsuario)
//        {
//            return IdUsuario == null ? false : true;

//        }
//        /// <summary>
//        /// Valida se campo de usuário esta preenchido;
//        /// true = o campo usuário esta preenchido;
//        /// false = o campo usuário esta em branco;
//        /// </summary>
//        /// <param name="usuario">string </param>
//        /// <returns>bool</returns>
//        public bool validaUsuarioEmBranco(string usuario)
//        {
//            if (usuario.Equals(string.Empty) || usuario.Equals(""))
//                return false;
//            return true;
//        }
//    }
//}
