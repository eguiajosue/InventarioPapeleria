// Decompiled with JetBrains decompiler
// Type: ExamenDistancia.DatosExamen
// Assembly: ExamenDistancia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 01C7BE8D-DB77-46F9-93C2-215C98B0A0C1
// Assembly location: C:\Users\josue\OneDrive\Desktop\ExamenDistancia_1.exe

using System;

namespace ExamenDistancia
{
  internal class DatosExamen : Configuracion
  {
    public DatosExamen()
    {
      this.NombreMateria = "Programación Orientada a Objetos";
      this.TipoExamen = "Examen práctico nivelación ";
      this.ClaveExamenAsignado = "POO-EP1-I-Distancia";
      this.TemaExamen = "1.- Int. al paradigma OO y Clases y objetos";
      this.FechaInicio = new DateTime(2022, 3, 4, 7, 55, 0);
      this.DuracionMinutos = 120;
      this.NombreArchivoConfiguracion = "c:\\apps\\FSMA3.sys";
      this.BotonAyuda = false;
      this.SitioWebAyuda = "";
      this.ImagenAyuda = false;
      this.Instrucciones = "INSTRUCCIONES, DOCUMENTOS A SUBIR Y PUNTUACIÓN\na) Diagrama de clases (20 puntos)\nb) Diagrama de flujo del método solicitado (20 puntos)\nc) Codificación.- Subir archivo comprimido sus apellidos en el nombre (60 puntos)\n*** SUBIR LOS DIAGRAMAS EN EL MISMO ARCHIVO *.vsdx de Microsoft Visio con un diagrama en cada página ***\nNúmero de control en el nombre del archivo de Visio. Ejemplos: 20100299.vsdx y LopezTakeyasBruno.zip";
      this.CodificarExamenes();
    }

    public void CodificarExamenes()
    {
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "1.",
        Redaccion = "63\u000EZs%j}ujsint%ij%flzf%uzwnknhfif%wjvznjwj%hfuyzwfw%qf%{jsyf%ij%qnywtx%ij%flzf1%hts{jwynwqtx%f%lfqtsjx%j%nruwnrnw%jq%wjxzqyfit%htsxnijwfsit%vzj%6%lfqøs%B%83<=:%qnywtx3%Jojruqt?%%Xn%qnywtx%B%:371%jsytshjx%%lfqtsjx%B%638<8=%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "2.",
        Redaccion = "73\u000EZs%nsljsnjwt%hn{nq%htsxywznwæ%zsf%hfwwjyjwf%~%ijxjf%hfuyzwfw%qf%inxyfshnf%js%pnqørjywtx%ufwf%hts{jwynwqf%f%rnqqfx%j%nruwnrnw%jq%wjxzqyfit3%Htsxnijwj%vzj%6%rn%B%63;5>%prx3%U3%jojr3%%7;39%prx%B%6;395<%rn3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "3.",
        Redaccion = "83\u000EJq%yzytw%ij%zs%jxyzinfsyj%wjvznjwj%hfqhzqfw%jq%uwtrjint%ij%hfqnknhfhntsjx%ij%zs%jxyzinfsyj3%Xzutslf%vzj%jq%jxyzinfsyj%hzwxf%8%rfyjwnfx3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "4.",
        Redaccion = "93\u000EZsf%jruwjxf%wjvznjwj%hfqhzqfw%jq%N[F%f%zs%fwyòhzqt%vzj%{jsij3%U3%jojr3%Xn%zs%fwyòhzqt%hzjxyf%)6:73;8%~%jq%utwhjsyfoj%ij%N[F%jx%65*1%jsytshjx%jq%N[F%jx%)6:37;3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "5.",
        Redaccion = ":3\u000EZs%{jsijitw%ij%ufqjyfx%ijxjf%hfqhzqfw%jq%ytyfq%ij%{jsyf%ijq%iòf3%Ijknsf%zsf%hqfxj%hts%qtx%fywngzytx%ij%%qf%hfsynifi%ij%ufqjyfx%{jsinifx%~%xz%jq%uwjhnt1%xzx%wjxujhyn{fx%uwtunjifijx%%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%ytyfq%ij%qf%{jsyf%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "6.",
        Redaccion = ";3\u000EZsf%htrjwhnfqn\u007Ffitwf%ijxjf%tytwlfw%zs%gtst%ijq%:%*%ij%qfx%{jsyfx%wjfqn\u007Ffifx%f%zs%jruqjfit3%Ijknsf%zsf%hqfxj%hts%jq%fywngzyt%ij%qf%hfsynifi%ij%{jsyf1%xz%uwtunjifi%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%ijq%gtst%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "7.",
        Redaccion = "<3\u000EZsf%jruwjxf%ijxjf%fzrjsyfw%9%*%fq%xzjqit%ij%zs%jruqjfit3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "8.",
        Redaccion = "=3\u000EZs%ljwjsyj%wjvznjwj%hfqhzqfw%jq%xzjqit%ij%zs%jruqjfit%ij%fhzjwit%f%qf%hfsynifi%ij%mtwfx%vzj%ywfgfof%~%jq%nrutwyj%f%uflfw%utw%mtwf3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "9.",
        Redaccion = ">3\u000EZs%fqgfönq%wjvznjwj%hfqhzqfw%xz%xzjqit%ijujsinjsit%ij%qf%hfsynifi%ij%qfiwnqqtx%htqthfitx%js%zsf%htsxywzhhnøs%~%jq%nrutwyj%vzj%qj%uflfs%utw%hfif%zst3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "10",
        Redaccion = "653\u000EZs%nsljsnjwt%wjvznjwj%hfqhzqfw%jq%æwjf%ij%zs%ywnæslzqt%xfgnjsit%vzj%qf%køwrzqf%jx%-gfxj%]%fqyzwf%.%473%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "11",
        Redaccion = "663\u000EZs%nsljsnjwt%wjvznjwj%hfqhzqfw%jq%æwjf%ij%zs%wjhyæslzqt%xfgnjsit%vzj%qf%køwrzqf%jx%-gfxj%]%fqyzwf.3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "12",
        Redaccion = "673\u000EZs%nsljsnjwt%wjvznjwj%hts{jwynw%zs%æslzqt%j}uwjxfit%js%lwfitx%f%wfinfsjx%xfgnjsit%vzj%qf%køwrzqf%jx%6=5%lwfitx%B%Un%/%Wfinfsjx3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "13",
        Redaccion = "683\u000EZs%yf}nxyf%wjvznjwj%hfqhzqfw%jq%uwjhnt%ij%zs%{nfoj%ijujsinjsit%ij%qtx%pnqørjywtx%wjhtwwnitx%~%jq%uwjhnt%utw%pnqørjywt3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "14",
        Redaccion = "693\u000EZs%hfwunsyjwt%rnij%zs%gfwwtyj%js%uzqlfifx%~%wjvznjwj%hts{jwynwqt%f%hjsyòrjywtx%xfgnjsit%vzj%6%uzqlfif%ynjsj%73:9%hrx3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "15",
        Redaccion = "6:3\u000EZsf%htruföòf%ujywtqjwf%ijxjf%hfqhzqfw%qf%hfsynifi%ij%qnywtx%{jsinitx%ij%ujywøqjt%itsij%jq%zxzfwnt%yjhqjf%qf%hfsynifi%ij%gfwwnqjx%{jsinitx%~%xfgnjsit%vzj%hfif%gfwwnq%fqrfhjsf%755%qnywtx3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "16",
        Redaccion = "6;3\u000EZsf%htxyzwjwf%wjvznjwj%hfqhzqfw%qf%hfsynifi%ij%yjqf%sjhjxfwnf%ufwf%wjfqn\u007Ffw%zsf%htwynsf%wjhyfslzqfw1%ufwf%jqqt%hfuyzwf%qfx%inrjsxntsjx%ij%zsf%htwynsf%-qfwlt%~%fshmt.3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "17",
        Redaccion = "6<3\u000EZs%yîhsnht%wjufwfitw%ij%htruzyfitwfx%wjhngj%zsf%htrnxnøs%ij%)%<:%ujxtx%utw%hfif%htruzyfitwf%wjufwfif%~%hfuyzwf%qf%hfsynifi%ij%htruzyfitwfx%wjufwfifx%~%wjvznjwj%hfqhzqfw%jq%ytyfq%ij%qf%htrnxnøs%wjhngnif3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "18",
        Redaccion = "6=3\u000EZs%xfxywj%wjhngj%zsf%htrnxnøs%ij%)%655%ujxtx%utw%hfif%ywfoj%htskjhhntsfit%~%hfuyzwf%qf%hfsynifi%ij%ywfojx%~%wjvznjwj%hfqhzqfw%jq%ytyfq%ij%qf%htrnxnøs%wjhngnif3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "19",
        Redaccion = "6>3\u000EZs%jxyzinfsyj%wjvznjwj%hfqhzqfw%qf%hfsynifi%ij%xjlzsitx%ywfsxhzwwnitx%js%hnjwyf%hfsynifi%ij%mtwfx1%ufwf%jqqt%hfuyzwf%qfx%mtwfx%ywfsxhzwwnifx%~%wjvznjwj%hfqhzqfw%qtx%xjlzsitx3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "20",
        Redaccion = "753\u000EZsf%jinytwnfq%qj%tytwlf%zsf%htrnxnøs%ij%)%:5%ujxtx%f%zs%fzytw%utw%hfif%qngwt%{jsinit%~%ufwf%jqqt%hfuyzwf%qf%hfsynifi%ij%qngwtx%{jsinitx%~%wjvznjwj%hfqhzqfw%qf%htrnxnøs3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "21",
        Redaccion = "763\u000EZs%jvznut%ij%gjnxgtq%qj%tytwlf%zs%gtst%ij%)%85%iqqx%f%zs%ozlfitw%utw%hfif%hfwwjwf%fstyfif1%ufwf%jqqt%hfuyzwf%qf%hfsynifi%ij%hfwwjwfx%fstyfifx%~%wjvznjwj%hfqhzqfw%jq%ytyfq%ijq%gtst3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "22",
        Redaccion = "773\u000EZs%unsytw%hfuyzwf%qf%hfsynifi%ij%rjywtx%hzfiwfitx%unsyfitx%~%jq%uwjhnt%vzj%htgwf%utw%hfif%zst%~%wjvznjwj%hfqhzqfw%jq%nrutwyj%f%htgwfw%utw%xz%ywfgfot3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "23",
        Redaccion = "783\u000EZsf%lwfsof%flzfhfyjwf%qj%tytwlf%zs%gtst%ij%)%:%ujxtx%utw%flzfhfyj%htxjhmfit%f%xz%wjhtqjhytw1%ufwf%jqqt%hfuyzwf%qf%hfsynifi%ij%flzfhfyjx%wjhtqjhyfitx%~%wjvznjwj%hfqhzqfw%jq%ytyfq%ijq%gtst%f%uflfw3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "24",
        Redaccion = "793\u000EZs%gzwøhwfyf%wjvznjwj%hfqhzqfw%xz%xzjqit%ijujsinjsit%ij%qf%hfsynifi%ij%hqnjsyjx%fyjsinitx%~%qf%hztyf%utw%hqnjsyj%fyjsinit3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "25",
        Redaccion = "7:3\u000EZsf%rjwhjwòf%ijxjf%hfqhzqfw%jq%ujwòrjywt%ij%zs%wtrgtnij%fuqnhfsit%qf%xnlznjsyj%køwrzqf%Ujwòrjywt%B%7%/%-QfitF0%QfitG.3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "26",
        Redaccion = "7;3\u000EZsf%ufvzjyjwòf%ijxjf%hfqhzqfw%jq%{tqzrjs%ij%xzx%hfofx%hÿgnhfx%fuqnhfsit%qf%xnlznjsyj%køwrzqf%[tqzrjs%B%Qfit%c%83%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "27",
        Redaccion = "7<3\u000EZs%inxujsxfwnt%ij%flzf%ijxjf%hfqhzqfw%jq%{tqzrjs%ij%xz%htsyjsjitw%hnqòsiwnht%rjinfsyj%qf%xnlznjsyj%køwrzqf%[tqzrjs%B%Un%/%Wfintc7%/%Fqyzwf3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "28",
        Redaccion = "7=3\u000EZsf%sj{jwòf%ijxjf%hfqhzqfw%jq%{tqzrjs%ij%xzx%htstx%j}uwjxfit%rjinfsyj%qf%køwrzqf%[tqzrjs%B%-Un%/%Wfintc7%/%Fqyzwf.%4%83%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "29",
        Redaccion = "7>3\u000EZsf%rfvznqfitwf%kfgwnhf%gtqfx%ij%zsnhjq%~%ijxjf%hfqhzqfw%jq%{tqzrjs%ij%hfif%zsf%ij%fhzjwit%f%qf%xnlznjsyj%køwrzqf%[tqzrjs%B%-9%/%Un%/%Wfintc8.%4%83%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "30",
        Redaccion = "853\u000EZs%xtqifitw%ijxjf%hfqhzqfw%qf%hfsynifi%ij%rfyjwnfq%-qtslnyzi%ij%hnwhzskjwjshnf.%ufwf%jqfgtwfw%fwtx%fuqnhfsit%qf%køwrzqf%Qtslnyzi%ij%hnwhzskjwjshnf%B%7%/%Un%/%Wfint3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "31",
        Redaccion = "863\u000EZsf%jinytwnfq%hfqhzqf%jq%uflt%ij%wjlfqòfx%f%xzx%fzytwjx%tytwlæsitqjx%jq%85%*%ij%qfx%{jsyfx%ij%xzx%qngwtx1%ufwf%jqqt%hfuyzwf%qf%{jsyf%ytyfq%ij%qtx%qngwtx%ij%zs%fzytw%~%wjvznjwj%hfqhzqfw%jq%rtsyt%ij%qfx%wjlfqòfx3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "32",
        Redaccion = "873\u000EZsf%jruwjxf%uwtizhj%jxkjwfx%sf{nijöfx%~%ijxjf%hfuyzwfw%jq%wfint%ij%zsf%jxkjwf%ufwf%hfqhzqfw%xz%xzujwknhnj%rjinfsyj%qf%køwrzqf%Xzujwknhnj%B%9%/%Un%/%Wfintc73%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "33",
        Redaccion = "883\u000EZs%fqgfönq%htqthf%rtxfnhtx%js%jq%unxt%ij%zsf%hfxf%~%wjvznjwj%hfqhzqfw%qf%xzujwknhnj%ijq%unxt%ij%qf%hthnsf%xfgnjsit%vzj%qf%hthnsf%jx%wjhyfslzqfw1%ufwf%jqqt%ijgj%hfuyzwfw%qfx%inrjsxntsjx%-Qfwlt%~%Fshmt.%ij%qf%hthnsf%ufwf%hfqhzqfw%jq%æwjf%rjinfsyj%qf%køwrzqf%Xzujwknhnj%B%Qfwlt%/%Fshmt3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "34",
        Redaccion = "893\u000EZs%snöt%ijxjf%hfqhzqfw%jq%æwjf%ij%xz%htrjyf%js%ktwrf%ij%wtrgt%rjinfsyj%qf%køwrzqf%Æwjf%B%-Infltsfq%rf~tw%/%Infltsfq%rjstw.%473%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "35",
        Redaccion = "8:3\u000EZs%nsljsnjwt%ijxjf%hfqhzqfw%jq%æwjf%ij%zs%wtrgtnij%rjinfsyj%qf%køwrzqf%Æwjf%B%Gfxj%/%Fqyzwf3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "36",
        Redaccion = "8;3\u000EZsf%ynjsif%ij%fgfwwtyjx%wjhngj%zs%9%*%ij%htrnxnøs%ij%qf%{jsyf%ytyfq%ij%wjkwjxhtx1%ufwf%jqqt%wjlnxywf%qf%hfsynifi%ij%wjkwjxhtx%{jsinitx%~%jq%uwjhnt%zsnyfwnt%~%wjvznjwj%hfqhzqfw%qf%htrnxnøs3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "37",
        Redaccion = "8<3\u000EZs%jruqjfit%ij%zsf%wjqtojwòf%wjhngj%zs%=%*%ij%htrnxnøs%ijq%nrutwyj%vzj%uflf%zs%hqnjsyj%utw%qf%wjufwfhnøs%ij%xz%wjqto1%ufwf%jqqt%wjlnxywf%jq%nrutwyj%f%uflfw%~%wjvznjwj%hfqhzqfw%qf%htrnxnøs3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "38",
        Redaccion = "8=3\u000EZs%jruqjfit%ijq%Ijufwyfrjsyt%ij%Fqzrgwfit%Uÿgqnht%htgwf%xz%xzjqit%ijujsinjsit%ij%qf%uwtizhyn{nifi%ij%xz%ywfgfot1%ufwf%jqqt%wjlnxywf%qf%hfsynifi%ij%qærufwfx%nsxyfqfifx%~%qf%hztyf%ij%nsxyfqfhnøs%~%wjvznjwj%hfqhzqfw%xz%xzjqit3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "39",
        Redaccion = "8>3\u000EZs%rîinht%ij%zs%htsxzqytwnt%uÿgqnht%htgwf%zs%;:%*%ijq%nrutwyj%uflfit%utw%qtx%ufhnjsyjx1%ufwf%jqqt%wjlnxywf%qf%hfsynifi%ij%ufhnjsyjx%fyjsinitx%~%jq%uwjhnt%utw%htsxzqyf%~%wjvznjwj%hfqhzqfw%xz%xzjqit3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "40",
        Redaccion = "953\u000EZs%fzytw%ij%hfshntsjx%wjhngj%jq%<%*%ij%wjlfqòfx%ijq%ytyfq%ij%ijxhfwlfx%ij%xz%hfshnøs%js%zsf%uqfyfktwrf%inlnyfq1%ufwf%jqqt%wjlnxywf%qf%hfsynifi%ij%ijxhfwlfx%~%jq%uwjhnt%utw%ijxhfwlf%~%wjvznjwj%hfqhzqfw%jq%rtsyt%ij%xzx%wjlfqòfx3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "41",
        Redaccion = "963\u000EZs%fwyjxfst%wjhngj%jq%>%*%ij%htrnxnøs%ijq%ytyfq%ij%qf%{jsyf%ij%qfx%fwyjxfsòfx1%ufwf%jqqt%wjlnxywf%qf%hfsynifi%ij%fwyjxfsòfx%{jsinifx%~%jq%uwjhnt%ij%hfif%zsf%~%wjvznjwj%hfqhzqfw%xz%htrnxnøs3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "42",
        Redaccion = "973\u000EZs%jruqjfit%ij%zsf%wjkfhhntsfwnf%wjhngj%zs%9%*%ij%htrnxnøs%utw%hfif%fhzrzqfitw%{jsinit1%ufwf%jqqt%wjlnxywf%qf%hfsynifi%ij%fhzrzqfitwjx%~%jq%uwjhnt%zsnyfwnt%~%wjvznjwj%hfqhzqfw%xz%htrnxnøs3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "43",
        Redaccion = "983\u000EZs%pòsijw%ufwynhzqfw%wjvznjwj%hfqhzqfw%jq%nslwjxt%ytyfq%utw%htshjuyt%ij%nsxhwnuhntsjx%ij%snötx1%ufwf%jqqt%wjlnxywf%qf%hfsynifi%ij%snötx%~%jq%htxyt%ij%nsxhwnuhnøs%ij%hfif%zst3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "44",
        Redaccion = "993\u000EZs%wjufwynitw%ij%un\u007F\u007Ffx%wjhngj%zs%;%*%ij%htrnxnøs%ijq%nrutwyj%uflfit%utw%hfif%un\u007F\u007Ff%jsywjlfif%~%ufwf%jqqt%wjlnxywf%qf%hfsynifi%ij%un\u007F\u007Ffx%jsywjlfifx%~%jq%uwjhnt%ij%hfif%zsf3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "45",
        Redaccion = "9:3\u000EZs%jruqjfit%ij%zsf%htruföòf%yjqjkøsnhf%wjhngj%zsf%htrnxnøs%ijq%8%*%utw%hfif%uqfs%yjqjkøsnht%{jsinit1%ufwf%jqqt%wjlnxywf%qf%hfsynifi%ij%uqfsjx%{jsinitx%~%jq%uwjhnt%ij%hfif%zst%~%wjvznjwj%hfqhzqfw%xz%htrnxnøs3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "46",
        Redaccion = "9;3\u000EZsf%ufxyjqjwòf%qj%tytwlf%zs%gtst%ij%)=5%ujxtx%f%xz%ufxyjqjwt%utw%hfif%ufxyjq%{jsinit1%ufwf%jqqt%wjlnxywf%qf%hfsynifi%ij%ufxyjqjx%{jsinitx%~%wjvznjwj%hfqhzqfw%jq%gtst3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "47",
        Redaccion = "9<3\u000EZsf%hwnxyfqjwòf%qj%ijxhzjsyf%f%zs%jruqjfit%jq%nrutwyj%ij%hfif%{niwnt%vzj%wtrufs%izwfsyj%xz%rfsjot1%ufwf%jqqt%wjlnxywf%jq%xzjqit%ijq%jruqjfit1%qf%hfsynifi%ij%{niwntx%wtytx%~%jq%uwjhnt%ij%hfif%zst%~%wjvznjwj%hfqhzqfw%jq%xzjqit%sjyt3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "48",
        Redaccion = "9=3\u000EZsf%kjwwjyjwòf%qj%ijxhzjsyf%f%zs%jruqjfit%jq%nrutwyj%ij%hfif%qfiwnqqt%wtyt%izwfsyj%xz%rfsjot1%ufwf%jqqt%wjlnxywf%jq%xzjqit%ijq%jruqjfit1%qf%hfsynifi%ij%qfiwnqqtx%wtytx%~%jq%uwjhnt%ij%hfif%zst%~%wjvznjwj%hfqhzqfw%jq%xzjqit%sjyt3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "49",
        Redaccion = "9>3\u000EZsf%htruföòf%ij%yjqjktsòf%hjqzqfw%qj%tytwlf%zs%<3:%*%ij%htrnxnøs%f%xz%jruqjfit%utw%qf%{jsyf%ij%hjqzqfwjx1%ufwf%jqqt%wjlnxywf%qf%hfsynifi%ij%yjqîktstx%{jsinitx1%jq%uwjhnt%ij%hfif%zst%~%wjvznjwj%hfqhzqfw%xz%htrnxnøs3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "50",
        Redaccion = ":53\u000EZsf%hfwsnhjwòf%qj%tytwlf%zsf%htrnxnøs%ij%;38%*%ij%htrnxnøs%f%zs%hfwsnhjwt%utw%hfif%pnqt%ij%hfwsj%jrufvzjyfif%~%{jsinif1%ufwf%jqqt%wjlnxywf%qf%hfsynifi%ij%pnqtx%{jsinitx%~%jq%uwjhnt%utw%pnqt%~%wjvznjwj%hfqhzqfw%qf%htrnxnøs3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "51",
        Redaccion = ":63\u000EZsf%ufsfijwòf%qj%tytwlf%zs%fzrjsyt%ijq%7%*%fq%xzjqit%ij%zs%ufsfijwt%utw%hfif%gtqnqqt%mtwsjfit1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%ufsfijwt%~%qf%hfsynifi%ij%unj\u007Ffx%ij%ufs%mtwsjfit%~%wjvznjwj%hfqhzqfw%jq%xzjqit%ytyfq%ijq%ufsfijwt3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "52",
        Redaccion = ":73\u000EZs%htqjlnt%ufwynhzqfw%ijxjf%fzrjsyfw%jq%:38%*%fq%xzjqit%ij%zs%rfjxywt%utw%hfif%jxyzinfsyj%fyjsinit%js%xz%hqfxj1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%rfjxywt%~%qf%hfsynifi%ij%jxyzinfsyjx%fyjsinitx%~%wjvznjwj%hfqhzqfw%jq%xzjqit%ytyfq%ij%xzx%rfjxywtx3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "53",
        Redaccion = ":83\u000EZsf%httujwfyn{f%ujxvzjwf%ijxjf%fzrjsyfw%637%*%fq%xzjqit%ij%zs%ujxhfitw%utw%hfif%mzfhmnsfslt%hfuyzwfit1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%ujxhfitw%~%qf%hfsynifi%ij%mzfhmnsfsltx%ujxhfitx%~%wjvznjwj%hfqhzqfw%jq%szj{t%xzjqit3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "54",
        Redaccion = ":93\u000EZsf%lwfsof%hnywòhtqf%ijxjf%fzrjsyfw%jq%<39%*%f%xz%un\u007Fhfitw%utw%hfif%pnqt%ij%sfwfsofx%wjhtqjhyfit1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%~%qf%hfsynifi%ij%pnqtx%wjhtqjhyfitx%~%wjvznjwj%hfqhzqfw%jq%szj{t%xzjqit3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "55",
        Redaccion = "::3\u000EJq%Ijufwyfrjsyt%ij%Xjw{nhnt%fq%Hqnjsyj%ijxjf%ijxhtsyfw%jq%837%*%fq%xzjqit%ij%zs%jruqjfit%utw%hfif%vzjof%wjhngnif1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%jruqjfit%~%qf%hfsynifi%ij%vzjofx%wjhngnifx%~%wjvznjwj%hfqhzqfw%jq%szj{t%xzjqit3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "56",
        Redaccion = ":;3\u000EJq%Htrnyî%Tqòrunht%Rj}nhfst%ijxjf%tytwlfw%zs%gtst%ij%)%67:1555%ujxtx%f%zs%fyqjyf%utw%hfif%rjifqqf%tgyjsnif%0%zs%gtst%ij%)%7:51555%ujxtx%utw%hfif%wjhtwi%rzsinfq%jxyfgqjhnit1%ufwf%jqqt%wjlnxywf%qf%hfsynifi%ij%rjifqqfx%~%ij%wjhtwix%rzsinfqjx%tgyjsnitx%~%wjvznjwj%hfqhzqfw%jq%ytyfq%ijq%gtst%utw%fxnlsfw3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "57",
        Redaccion = ":<3\u000EZs%gfsht%ijxjf%tytwlfw%zs%gtst%ijq%736%*%ijq%xzjqit%ij%zs%jruqjfit%utw%hfif%hqnjsyj%fyjsinit1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%jruqjfit%~%qf%hfsynifi%ij%hqnjsyjx%fyjsinitx%~%wjvznjwj%hfqhzqfw%jq%szj{t%xzjqit3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "58",
        Redaccion = ":=3\u000EZsf%hqòsnhf%ijsyfq%ijxjf%tytwlfw%zs%gtst%ij%)%6:5%ujxtx%f%zs%ijsynxyf%utw%hfif%unj\u007Ff%ijsyfq%fyjsinif%~%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%ijsynxyf1%qf%hfsynifi%ij%unj\u007Ffx%ijsyfqjx%fyjsinifx%~%wjvznjwj%hfqhzqfw%jq%szj{t%xzjqit3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "59",
        Redaccion = ":>3\u000EZs%sjlthnt%ij%wjufwfhnøs%ij%hfq\u007Ffit%ijxjf%tytwlfw%zs%fzrjsyt%ijq%73<%*%f%zs%\u007Ffufyjwt%utw%jq%nrutwyj%uflfit%utw%qf%wjufwfhnøs%ij%hfq\u007Ffit1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%\u007Ffufyjwt1%qf%hfsynifi%ij%\u007Ffufytx%wjufwfitx%~%jq%uwjhnt%f%uflfw%utw%hfif%\u007Ffufyt%wjufwfit%~%wjvznjwj%hfqhzqfw%jq%szj{t%xzjqit%ijq%\u007Ffufyjwt3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "60",
        Redaccion = ";53\u000EZsf%jruwjxf%yjqj{nxtwf%ijxjf%fzrjsyfw%=3>%*%jq%xzjqit%ij%zs%jruqjfit%ijq%Ijufwyfrjsyt%ij%Rjwhfityjhsnf%utw%hfif%htrjwhnfq%{jsinit1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%jruqjfit1%qf%hfsynifi%ij%htrjwhnfqjx%{jsinitx%~%wjvznjwj%hfqhzqfw%jq%szj{t%xzjqit3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "61",
        Redaccion = ";63\u000EZs%wjxyfzwfsyj%ij%htrnif%wæunif%ijxjf%tytwlfw%zs%gtst%ij%)%:%ujxtx%f%xz%hthnsjwt%utw%hfif%mfrgzwlzjxf%uwjufwfif1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%hthnsjwt1%qf%hfsynifi%ij%mfrgzwlzjxfx%uwjufwfifx%~%wjvznjwj%hfqhzqfw%jq%szj{t%xzjqit3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "62",
        Redaccion = ";73\u000EZs%ujwnøinht%ijxjf%fzrjsyfw%637%*%jq%xzjqit%ij%zs%ujwntinxyf%utw%hfif%fwyòhzqt%uzgqnhfit1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%ujwntinxyf1%qf%hfsynifi%ij%fwyòhzqtx%uzgqnhfitx%~%wjvznjwj%hfqhzqfw%jq%szj{t%xzjqit3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "63",
        Redaccion = ";83\u000EZs%sjlthnt%vzj%{jsij%unöfyfx%qj%ijxhzjsyf%jq%nrutwyj%ij%hfif%unöfyf%iföfif%fq%jruqjfit%vzj%qfx%wjufwyj1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%jruqjfit1%jq%uwjhnt%ij%hfif%unöfyf1%qf%hfsynifi%ij%unöfyfx%iföfifx%~%wjvznjwj%hfqhzqfw%jq%xzjqit%sjyt3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "64",
        Redaccion = ";93\u000EZsf%jrgtyjqqfitwf%qj%ijxhzjsyf%jq%nrutwyj%ij%hfif%gtyjqqf%ij%wjkwjxht%vzj%wtruf%zs%wjufwynitw1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%wjufwynitw1%jq%uwjhnt%ij%hfif%wjkwjxht1%qf%hfsynifi%ij%gtyjqqfx%iföfifx%~%wjvznjwj%hfqhzqfw%jq%xzjqit%sjyt3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "65",
        Redaccion = ";:3\u000EZs%yjfywt%ijxjf%fzrjsyfw%739%*%fq%xzjqit%ij%xz%yfvznqqjwt%utw%hfif%gtqjyt%vzj%{jsif1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%yfvznqqjwt1%qf%hfsynifi%ij%gtqjytx%{jsinitx%~%wjvznjwj%hfqhzqfw%jq%xzjqit%sjyt3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "66",
        Redaccion = ";;3\u000EJq%Ijuyt3%ij%Tgwfx%Uÿgqnhfx%ijxjf%tytwlfw%zs%gtst%ij%):5%ujxtx%f%zs%jruqjfit%utw%hfif%gfhmj%wjufwfit1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%jruqjfit1%qf%hfsynifi%ij%gfhmjx%wjufwfitx%~%wjvznjwj%hfqhzqfw%jq%xzjqit%sjyt3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "67",
        Redaccion = ";<3\u000EZsf%jruwjxf%ij%uzgqnhnifi%ijxjf%tytwlfw%zs%gtst%ij%)53:5%f%zs%jruqjfit%utw%hfif%ktqqjyt%wjufwynit1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%jruqjfit1%qf%hfsynifi%ij%ktqqjytx%wjufwynitx%~%wjvznjwj%hfqhzqfw%jq%xzjqit%sjyt3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "68",
        Redaccion = ";=3\u000EZs%sjlthnt%ij%fzyt2{niwntx%ijxjf%fzrjsyfw%83<%*%jq%xzjqit%ij%zs%jruqjfit%utw%hfif%{niwnt%nsxyfqfit1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%jruqjfit1%qf%hfsynifi%ij%{niwntx%nsxyfqfitx%~%wjvznjwj%hfqhzqfw%jq%xzjqit%sjyt3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "69",
        Redaccion = ";>3\u000EZs%yfqqjw%ij%jsijwj\u007Ffit%~%unsyzwf%ij%fzytx%ijxjf%tytwlfw%zs%gtst%f%xz%unsytw3%Jq%gtst%xj%hfqhzqf%tytwlfsit%jq%>%*%ijq%nrutwyj%htgwfit%utw%unsyfw%zs%fzyt1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj%ijq%unsytw1%jq%nrutwyj%htgwfit%utw%jq%ywfgfot%wjfqn\u007Ffit%~%wjvznjwj%hfqhzqfw%jq%szj{t%xzjqit3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "70",
        Redaccion = "<53\u000EZs%rjxjwt%ynjsj%zs%xzjqit%gfxj%~%wjhngj%zsf%uwtunsf%ijq%6:%*%ijq%nrutwyj%ij%qf%hzjsyf%ij%qf%rjxf%vzj%fyjsinø1%ufwf%jqqt%wjlnxywf%jq%xzjqit%gfxj1%jq%nrutwyj%ij%qf%hzjsyf%ij%qf%rjxf%fyjsinif%~%wjvznjwj%hfqhzqfw%jq%szj{t%xzjqit3%Ijknsf%zsf%hqfxj%hts%qtx%htrutsjsyjx%sjhjxfwntx%-fywngzytx%~%uwtunjifijx.%~%zs%rîytit%vzj%hfqhzqj%~%ij{zjq{f%jq%{fqtw%xtqnhnyfit%ufwf%xjw%nruwjxt%ijxij%qf%ktwrf%uwnshnufq3",
        Inciso = ""
      });
    }
  }
}
