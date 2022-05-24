// Decompiled with JetBrains decompiler
// Type: ExamenDistancia.DatosExamen
// Assembly: ExamenDistancia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 929C66B3-BE42-4041-A340-38CD61776081
// Assembly location: C:\Users\josue\OneDrive\Desktop\ExamenDistancia_2.exe

using System;

namespace ExamenDistancia
{
  internal class DatosExamen : Configuracion
  {
    public DatosExamen()
    {
      this.NombreMateria = "Programación Orientada a Objetos";
      this.TipoExamen = "Examen práctico ordinario ";
      this.ClaveExamenAsignado = "Ord-examen practico unidad 2 (e) (Distancia)";
      this.TemaExamen = "2.- Relaciones (herencia, composición y agregación";
      this.FechaInicio = new DateTime(2022, 3, 31, 7, 55, 0);
      this.DuracionMinutos = 120;
      this.NombreArchivoConfiguracion = "c:\\apps\\WCARMAC.sys";
      this.BotonAyuda = false;
      this.SitioWebAyuda = "";
      this.ImagenAyuda = false;
      this.Instrucciones = "INSTRUCCIONES, DOCUMENTOS A SUBIR Y PUNTUACIÓN\na) Diagrama de clases (20 puntos)\nb) Diagrama de flujo (20 puntos)\nc) Codificación.- Subir archivo comprimido sus apellidos en el nombre (60 puntos)\n*** SUBIR LOS DIAGRAMAS EN EL MISMO ARCHIVO *.vsdx de Microsoft Visio con un diagrama en cada página ***\nNúmero de control en el nombre del archivo de Visio. Ejemplos: 20100299.vsdx y LopezTakeyasBruno.zip";
      this.CodificarExamenes();
    }

    public void CodificarExamenes()
    {
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "A1)",
        Redaccion = "F32%Zs%mtxunyfq%htsywfyf%ij%rfsjwf%j}hqzxn{f%f%{fwntx%rîinhtx?%\u000FQtx%ifytx%ijq%mtxunyfq%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EHnzifi\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%rîinht%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EXj}t%-rfxhzqnst%t%kjrjsnst.\u000F\u00BC\u000EJifi\u000F\u00BC\u000EJxujhnfqnifi\u000F\u00BC\u000EUfhnjsyjx%fyjsinitx\u000F\u000FHtsxnijwfsit%vzj%qtx%rîinhtx%st%uzjijs%ywfgfofw%f%{fwntx%mtxunyfqjx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "6.\u000EIj{zjq{f%jq%tgojyt%hts%qtx%ifytx%ijq%rîinht%hts%ræx%ufhnjsyjx%fyjsinitx"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "A2)",
        Redaccion = "F32%Zs%mtxunyfq%htsywfyf%ij%rfsjwf%j}hqzxn{f%f%{fwntx%rîinhtx?%\u000FQtx%ifytx%ijq%mtxunyfq%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EHnzifi\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%rîinht%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EXj}t%-rfxhzqnst%t%kjrjsnst.\u000F\u00BC\u000EJifi\u000F\u00BC\u000EJxujhnfqnifi\u000F\u00BC\u000EUfhnjsyjx%fyjsinitx\u000F\u000FHtsxnijwfsit%vzj%qtx%rîinhtx%st%uzjijs%ywfgfofw%f%{fwntx%mtxunyfqjx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "7.\u000EIj{zjq{f%jq%tgojyt%hts%qtx%ifytx%ijq%rîinht%hts%rjstw%jifi"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "A3)",
        Redaccion = "F32%Zs%mtxunyfq%htsywfyf%ij%rfsjwf%j}hqzxn{f%f%{fwntx%rîinhtx?%\u000FQtx%ifytx%ijq%mtxunyfq%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EHnzifi\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%rîinht%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EXj}t%-rfxhzqnst%t%kjrjsnst.\u000F\u00BC\u000EJifi\u000F\u00BC\u000EJxujhnfqnifi\u000F\u00BC\u000EUfhnjsyjx%fyjsinitx\u000F\u000FHtsxnijwfsit%vzj%qtx%rîinhtx%st%uzjijs%ywfgfofw%f%{fwntx%mtxunyfqjx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "8.\u000EIj{zjq{f%jq%tgojyt%hts%qtx%ifytx%ijq%rîinht%{fwøs%hts%rjstx%ufhnjsyjx%fyjsinitx"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "A4)",
        Redaccion = "F32%Zs%mtxunyfq%htsywfyf%ij%rfsjwf%j}hqzxn{f%f%{fwntx%rîinhtx?%\u000FQtx%ifytx%ijq%mtxunyfq%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EHnzifi\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%rîinht%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EXj}t%-rfxhzqnst%t%kjrjsnst.\u000F\u00BC\u000EJifi\u000F\u00BC\u000EJxujhnfqnifi\u000F\u00BC\u000EUfhnjsyjx%fyjsinitx\u000F\u000FHtsxnijwfsit%vzj%qtx%rîinhtx%st%uzjijs%ywfgfofw%f%{fwntx%mtxunyfqjx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "9.\u000EIj{zjq{f%jq%tgojyt%hts%qtx%ifytx%ijq%rîinht%kjrjsnst%hts%rf~tw%jifi"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "A5)",
        Redaccion = "F32%Zs%mtxunyfq%htsywfyf%ij%rfsjwf%j}hqzxn{f%f%{fwntx%rîinhtx?%\u000FQtx%ifytx%ijq%mtxunyfq%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EHnzifi\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%rîinht%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EXj}t%-rfxhzqnst%t%kjrjsnst.\u000F\u00BC\u000EJifi\u000F\u00BC\u000EJxujhnfqnifi\u000F\u00BC\u000EUfhnjsyjx%fyjsinitx\u000F\u000FHtsxnijwfsit%vzj%qtx%rîinhtx%st%uzjijs%ywfgfofw%f%{fwntx%mtxunyfqjx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = ":.\u000EIj{zjq{f%jq%tgojyt%hts%qtx%ifytx%ijq%rîinht%kjrjsnst%hts%ræx%ufhnjsyjx%fyjsinitx"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "A6)",
        Redaccion = "F32%Zs%mtxunyfq%htsywfyf%ij%rfsjwf%j}hqzxn{f%f%{fwntx%rîinhtx?%\u000FQtx%ifytx%ijq%mtxunyfq%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EHnzifi\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%rîinht%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EXj}t%-rfxhzqnst%t%kjrjsnst.\u000F\u00BC\u000EJifi\u000F\u00BC\u000EJxujhnfqnifi\u000F\u00BC\u000EUfhnjsyjx%fyjsinitx\u000F\u000FHtsxnijwfsit%vzj%qtx%rîinhtx%st%uzjijs%ywfgfofw%f%{fwntx%mtxunyfqjx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = ";.\u000EXzrj%qf%hfsynifi%ij%ufhnjsyjx%fyjsinitx%utw%jq%mtxunyfq"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "A7)",
        Redaccion = "F32%Zs%mtxunyfq%htsywfyf%ij%rfsjwf%j}hqzxn{f%f%{fwntx%rîinhtx?%\u000FQtx%ifytx%ijq%mtxunyfq%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EHnzifi\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%rîinht%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EXj}t%-rfxhzqnst%t%kjrjsnst.\u000F\u00BC\u000EJifi\u000F\u00BC\u000EJxujhnfqnifi\u000F\u00BC\u000EUfhnjsyjx%fyjsinitx\u000F\u000FHtsxnijwfsit%vzj%qtx%rîinhtx%st%uzjijs%ywfgfofw%f%{fwntx%mtxunyfqjx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "<.\u000EHfqhzqj%jq%uwtrjint%ij%ufhnjsyjx%fyjsinitx%utw%rîinht"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "A8)",
        Redaccion = "F32%Zs%mtxunyfq%htsywfyf%ij%rfsjwf%j}hqzxn{f%f%{fwntx%rîinhtx?%\u000FQtx%ifytx%ijq%mtxunyfq%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EHnzifi\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%rîinht%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EXj}t%-rfxhzqnst%t%kjrjsnst.\u000F\u00BC\u000EJifi\u000F\u00BC\u000EJxujhnfqnifi\u000F\u00BC\u000EUfhnjsyjx%fyjsinitx\u000F\u000FHtsxnijwfsit%vzj%qtx%rîinhtx%st%uzjijs%ywfgfofw%f%{fwntx%mtxunyfqjx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "=.\u000EHzjsyj%qf%hfsynifi%ij%rîinhtx%vzj%fyjsinjwts%ræx%ij%6:%ufhnjsyjx"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "A9)",
        Redaccion = "F32%Zs%mtxunyfq%htsywfyf%ij%rfsjwf%j}hqzxn{f%f%{fwntx%rîinhtx?%\u000FQtx%ifytx%ijq%mtxunyfq%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EHnzifi\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%rîinht%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EXj}t%-rfxhzqnst%t%kjrjsnst.\u000F\u00BC\u000EJifi\u000F\u00BC\u000EJxujhnfqnifi\u000F\u00BC\u000EUfhnjsyjx%fyjsinitx\u000F\u000FHtsxnijwfsit%vzj%qtx%rîinhtx%st%uzjijs%ywfgfofw%f%{fwntx%mtxunyfqjx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = ">.\u000EHzjsyj%qf%hfsynifi%ij%rîinhtx%hz~f%jxujhnfqnifi%jx%‡Ujinfywòf•"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "A10",
        Redaccion = "F32%Zs%mtxunyfq%htsywfyf%ij%rfsjwf%j}hqzxn{f%f%{fwntx%rîinhtx?%\u000FQtx%ifytx%ijq%mtxunyfq%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EHnzifi\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%rîinht%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EXj}t%-rfxhzqnst%t%kjrjsnst.\u000F\u00BC\u000EJifi\u000F\u00BC\u000EJxujhnfqnifi\u000F\u00BC\u000EUfhnjsyjx%fyjsinitx\u000F\u000FHtsxnijwfsit%vzj%qtx%rîinhtx%st%uzjijs%ywfgfofw%f%{fwntx%mtxunyfqjx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "65.\u000EHzjsyj%qf%hfsynifi%ij%rîinhtx%{fwtsjx"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "A11",
        Redaccion = "F32%Zs%mtxunyfq%htsywfyf%ij%rfsjwf%j}hqzxn{f%f%{fwntx%rîinhtx?%\u000FQtx%ifytx%ijq%mtxunyfq%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EHnzifi\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%rîinht%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EXj}t%-rfxhzqnst%t%kjrjsnst.\u000F\u00BC\u000EJifi\u000F\u00BC\u000EJxujhnfqnifi\u000F\u00BC\u000EUfhnjsyjx%fyjsinitx\u000F\u000FHtsxnijwfsit%vzj%qtx%rîinhtx%st%uzjijs%ywfgfofw%f%{fwntx%mtxunyfqjx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "66.\u000EXzrj%qf%hfsynifi%ij%ufhnjsyjx%fyjsinitx%utw%rîinhtx%kjrjsnstx"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "A12",
        Redaccion = "F32%Zs%mtxunyfq%htsywfyf%ij%rfsjwf%j}hqzxn{f%f%{fwntx%rîinhtx?%\u000FQtx%ifytx%ijq%mtxunyfq%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EHnzifi\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%rîinht%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EXj}t%-rfxhzqnst%t%kjrjsnst.\u000F\u00BC\u000EJifi\u000F\u00BC\u000EJxujhnfqnifi\u000F\u00BC\u000EUfhnjsyjx%fyjsinitx\u000F\u000FHtsxnijwfsit%vzj%qtx%rîinhtx%st%uzjijs%ywfgfofw%f%{fwntx%mtxunyfqjx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "67.\u000EHfqhzqj%jq%uwtrjint%ij%ufhnjsyjx%fyjsinitx%utw%rîinhtx%{fwtsjx"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "A13",
        Redaccion = "F32%Zs%mtxunyfq%htsywfyf%ij%rfsjwf%j}hqzxn{f%f%{fwntx%rîinhtx?%\u000FQtx%ifytx%ijq%mtxunyfq%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EHnzifi\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%rîinht%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EXj}t%-rfxhzqnst%t%kjrjsnst.\u000F\u00BC\u000EJifi\u000F\u00BC\u000EJxujhnfqnifi\u000F\u00BC\u000EUfhnjsyjx%fyjsinitx\u000F\u000FHtsxnijwfsit%vzj%qtx%rîinhtx%st%uzjijs%ywfgfofw%f%{fwntx%mtxunyfqjx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "68.\u000EHzjsyj%qf%hfsynifi%ij%rîinhtx%ij%hfif%xj}t"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "A14",
        Redaccion = "F32%Zs%mtxunyfq%htsywfyf%ij%rfsjwf%j}hqzxn{f%f%{fwntx%rîinhtx?%\u000FQtx%ifytx%ijq%mtxunyfq%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EHnzifi\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%rîinht%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EXj}t%-rfxhzqnst%t%kjrjsnst.\u000F\u00BC\u000EJifi\u000F\u00BC\u000EJxujhnfqnifi\u000F\u00BC\u000EUfhnjsyjx%fyjsinitx\u000F\u000FHtsxnijwfsit%vzj%qtx%rîinhtx%st%uzjijs%ywfgfofw%f%{fwntx%mtxunyfqjx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "69.\u000EIjyjwrnsj%xn%mf~%ræx1%rjstx%t%nlzfq%hfsynifi%ij%rîinhtx%mtrgwjx%t%rzojwjx"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "A15",
        Redaccion = "F32%Zs%mtxunyfq%htsywfyf%ij%rfsjwf%j}hqzxn{f%f%{fwntx%rîinhtx?%\u000FQtx%ifytx%ijq%mtxunyfq%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EHnzifi\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%rîinht%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EXj}t%-rfxhzqnst%t%kjrjsnst.\u000F\u00BC\u000EJifi\u000F\u00BC\u000EJxujhnfqnifi\u000F\u00BC\u000EUfhnjsyjx%fyjsinitx\u000F\u000FHtsxnijwfsit%vzj%qtx%rîinhtx%st%uzjijs%ywfgfofw%f%{fwntx%mtxunyfqjx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "6:.\u000EHzjsyj%qf%hfsynifi%ij%rîinhtx%{fwtsjx%vzj%fyjsinjwts%ræx%ij%67%ufhnjsyjx"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "B16",
        Redaccion = "G32%Zsf%ufujqjwòf%{jsij%inkjwjsyjx%ynutx%ij%gtqòlwfktx\u000FQtx%ifytx%ij%qf%ufujqjwòf%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EInwjhhnøs\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%ynut%ij%gtqòlwfkt%xts?\u000F\u00BC\u000EHqf{j%\u000F\u00BC\u000EUwjhnt\u000F\u00BC\u000EYfrföt\u000F\u00BC\u000EHfsynifi%ij%jojruqfwjx%{jsinitx\u000F\u00BC\u000EHtqtw%-f\u007Fzq1%sjlwt%t%wtot.\u000F\u000FHtsxnijwfsit%vzj%qtx%gtqòlwfktx%uzjijs%xjw%inxywngznitx%js%{fwnfx%ufujqjwòfx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "6;.\u000EIj{zjq{f%jq%tgojyt%hts%qtx%ifytx%ijq%gtqòlwfkt%ræx%{jsinit"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "B17",
        Redaccion = "G32%Zsf%ufujqjwòf%{jsij%inkjwjsyjx%ynutx%ij%gtqòlwfktx\u000FQtx%ifytx%ij%qf%ufujqjwòf%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EInwjhhnøs\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%ynut%ij%gtqòlwfkt%xts?\u000F\u00BC\u000EHqf{j%\u000F\u00BC\u000EUwjhnt\u000F\u00BC\u000EYfrföt\u000F\u00BC\u000EHfsynifi%ij%jojruqfwjx%{jsinitx\u000F\u00BC\u000EHtqtw%-f\u007Fzq1%sjlwt%t%wtot.\u000F\u000FHtsxnijwfsit%vzj%qtx%gtqòlwfktx%uzjijs%xjw%inxywngznitx%js%{fwnfx%ufujqjwòfx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "6<.\u000EIj{zjq{f%jq%tgojyt%hts%qtx%ifytx%ijq%gtqòlwfkt%ij%htqtw%‡F\u007Fzq•%hts%jq%rjstw%uwjhnt"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "B18",
        Redaccion = "G32%Zsf%ufujqjwòf%{jsij%inkjwjsyjx%ynutx%ij%gtqòlwfktx\u000FQtx%ifytx%ij%qf%ufujqjwòf%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EInwjhhnøs\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%ynut%ij%gtqòlwfkt%xts?\u000F\u00BC\u000EHqf{j%\u000F\u00BC\u000EUwjhnt\u000F\u00BC\u000EYfrföt\u000F\u00BC\u000EHfsynifi%ij%jojruqfwjx%{jsinitx\u000F\u00BC\u000EHtqtw%-f\u007Fzq1%sjlwt%t%wtot.\u000F\u000FHtsxnijwfsit%vzj%qtx%gtqòlwfktx%uzjijs%xjw%inxywngznitx%js%{fwnfx%ufujqjwòfx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "6=.\u000EIj{zjq{f%jq%tgojyt%hts%qtx%ifytx%ijq%gtqòlwfkt%ij%htqtw%‡Wtot•%hts%rf~tw%hfsynifi%ij%jojruqfwjx%{jsinitx"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "B19",
        Redaccion = "G32%Zsf%ufujqjwòf%{jsij%inkjwjsyjx%ynutx%ij%gtqòlwfktx\u000FQtx%ifytx%ij%qf%ufujqjwòf%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EInwjhhnøs\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%ynut%ij%gtqòlwfkt%xts?\u000F\u00BC\u000EHqf{j%\u000F\u00BC\u000EUwjhnt\u000F\u00BC\u000EYfrföt\u000F\u00BC\u000EHfsynifi%ij%jojruqfwjx%{jsinitx\u000F\u00BC\u000EHtqtw%-f\u007Fzq1%sjlwt%t%wtot.\u000F\u000FHtsxnijwfsit%vzj%qtx%gtqòlwfktx%uzjijs%xjw%inxywngznitx%js%{fwnfx%ufujqjwòfx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "6>.\u000EIj{zjq{f%jq%tgojyt%hts%qtx%ifytx%ijq%gtqòlwfkt%ij%htqtw%‡sjlwt•%ræx%{jsinit"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "B20",
        Redaccion = "G32%Zsf%ufujqjwòf%{jsij%inkjwjsyjx%ynutx%ij%gtqòlwfktx\u000FQtx%ifytx%ij%qf%ufujqjwòf%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EInwjhhnøs\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%ynut%ij%gtqòlwfkt%xts?\u000F\u00BC\u000EHqf{j%\u000F\u00BC\u000EUwjhnt\u000F\u00BC\u000EYfrföt\u000F\u00BC\u000EHfsynifi%ij%jojruqfwjx%{jsinitx\u000F\u00BC\u000EHtqtw%-f\u007Fzq1%sjlwt%t%wtot.\u000F\u000FHtsxnijwfsit%vzj%qtx%gtqòlwfktx%uzjijs%xjw%inxywngznitx%js%{fwnfx%ufujqjwòfx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "75.\u000EIj{zjq{f%jq%tgojyt%hts%qtx%ifytx%ijq%gtqòlwfkt%ij%htqtw%‡f\u007Fzq•%ij%rjstw%yfrföt"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "B21",
        Redaccion = "G32%Zsf%ufujqjwòf%{jsij%inkjwjsyjx%ynutx%ij%gtqòlwfktx\u000FQtx%ifytx%ij%qf%ufujqjwòf%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EInwjhhnøs\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%ynut%ij%gtqòlwfkt%xts?\u000F\u00BC\u000EHqf{j%\u000F\u00BC\u000EUwjhnt\u000F\u00BC\u000EYfrföt\u000F\u00BC\u000EHfsynifi%ij%jojruqfwjx%{jsinitx\u000F\u00BC\u000EHtqtw%-f\u007Fzq1%sjlwt%t%wtot.\u000F\u000FHtsxnijwfsit%vzj%qtx%gtqòlwfktx%uzjijs%xjw%inxywngznitx%js%{fwnfx%ufujqjwòfx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "76.\u000EXzrj%qf%hfsynifi%ij%gtqòlwfktx%{jsinitx%utw%qf%ufujqjwòf"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "B22",
        Redaccion = "G32%Zsf%ufujqjwòf%{jsij%inkjwjsyjx%ynutx%ij%gtqòlwfktx\u000FQtx%ifytx%ij%qf%ufujqjwòf%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EInwjhhnøs\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%ynut%ij%gtqòlwfkt%xts?\u000F\u00BC\u000EHqf{j%\u000F\u00BC\u000EUwjhnt\u000F\u00BC\u000EYfrföt\u000F\u00BC\u000EHfsynifi%ij%jojruqfwjx%{jsinitx\u000F\u00BC\u000EHtqtw%-f\u007Fzq1%sjlwt%t%wtot.\u000F\u000FHtsxnijwfsit%vzj%qtx%gtqòlwfktx%uzjijs%xjw%inxywngznitx%js%{fwnfx%ufujqjwòfx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "77.\u000EHfqhzqj%jq%uwtrjint%ij%gtqòlwfktx%{jsinitx"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "B23",
        Redaccion = "G32%Zsf%ufujqjwòf%{jsij%inkjwjsyjx%ynutx%ij%gtqòlwfktx\u000FQtx%ifytx%ij%qf%ufujqjwòf%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EInwjhhnøs\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%ynut%ij%gtqòlwfkt%xts?\u000F\u00BC\u000EHqf{j%\u000F\u00BC\u000EUwjhnt\u000F\u00BC\u000EYfrföt\u000F\u00BC\u000EHfsynifi%ij%jojruqfwjx%{jsinitx\u000F\u00BC\u000EHtqtw%-f\u007Fzq1%sjlwt%t%wtot.\u000F\u000FHtsxnijwfsit%vzj%qtx%gtqòlwfktx%uzjijs%xjw%inxywngznitx%js%{fwnfx%ufujqjwòfx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "78.\u000EHzjsyj%qtx%ynutx%ij%gtqòlwfktx%ij%qtx%vzj%xj%{jsinjwts%rjstx%ij%855%jojruqfwjx"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "B24",
        Redaccion = "G32%Zsf%ufujqjwòf%{jsij%inkjwjsyjx%ynutx%ij%gtqòlwfktx\u000FQtx%ifytx%ij%qf%ufujqjwòf%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EInwjhhnøs\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%ynut%ij%gtqòlwfkt%xts?\u000F\u00BC\u000EHqf{j%\u000F\u00BC\u000EUwjhnt\u000F\u00BC\u000EYfrföt\u000F\u00BC\u000EHfsynifi%ij%jojruqfwjx%{jsinitx\u000F\u00BC\u000EHtqtw%-f\u007Fzq1%sjlwt%t%wtot.\u000F\u000FHtsxnijwfsit%vzj%qtx%gtqòlwfktx%uzjijs%xjw%inxywngznitx%js%{fwnfx%ufujqjwòfx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "79.\u000EHzjsyj%qf%hfsynifi%ij%gtqòlwfktx%{jsinitx%ij%htqtw%‡f\u007Fzq•"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "B25",
        Redaccion = "G32%Zsf%ufujqjwòf%{jsij%inkjwjsyjx%ynutx%ij%gtqòlwfktx\u000FQtx%ifytx%ij%qf%ufujqjwòf%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EInwjhhnøs\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%ynut%ij%gtqòlwfkt%xts?\u000F\u00BC\u000EHqf{j%\u000F\u00BC\u000EUwjhnt\u000F\u00BC\u000EYfrföt\u000F\u00BC\u000EHfsynifi%ij%jojruqfwjx%{jsinitx\u000F\u00BC\u000EHtqtw%-f\u007Fzq1%sjlwt%t%wtot.\u000F\u000FHtsxnijwfsit%vzj%qtx%gtqòlwfktx%uzjijs%xjw%inxywngznitx%js%{fwnfx%ufujqjwòfx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "7:.\u000EHfqhzqj%jq%uwtrjint%ij%uwjhnt%ij%ytitx%qtx%gtqòlwfktx"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "B26",
        Redaccion = "G32%Zsf%ufujqjwòf%{jsij%inkjwjsyjx%ynutx%ij%gtqòlwfktx\u000FQtx%ifytx%ij%qf%ufujqjwòf%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EInwjhhnøs\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%ynut%ij%gtqòlwfkt%xts?\u000F\u00BC\u000EHqf{j%\u000F\u00BC\u000EUwjhnt\u000F\u00BC\u000EYfrföt\u000F\u00BC\u000EHfsynifi%ij%jojruqfwjx%{jsinitx\u000F\u00BC\u000EHtqtw%-f\u007Fzq1%sjlwt%t%wtot.\u000F\u000FHtsxnijwfsit%vzj%qtx%gtqòlwfktx%uzjijs%xjw%inxywngznitx%js%{fwnfx%ufujqjwòfx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "7;.\u000EHzjsyj%qtx%ynutx%ij%gtqòlwfktx%‡wtotx•%vzj%hzjxyfs%ræx%ij%)67355"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "B27",
        Redaccion = "G32%Zsf%ufujqjwòf%{jsij%inkjwjsyjx%ynutx%ij%gtqòlwfktx\u000FQtx%ifytx%ij%qf%ufujqjwòf%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EInwjhhnøs\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%ynut%ij%gtqòlwfkt%xts?\u000F\u00BC\u000EHqf{j%\u000F\u00BC\u000EUwjhnt\u000F\u00BC\u000EYfrföt\u000F\u00BC\u000EHfsynifi%ij%jojruqfwjx%{jsinitx\u000F\u00BC\u000EHtqtw%-f\u007Fzq1%sjlwt%t%wtot.\u000F\u000FHtsxnijwfsit%vzj%qtx%gtqòlwfktx%uzjijs%xjw%inxywngznitx%js%{fwnfx%ufujqjwòfx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "7<.\u000EHfqhzqj%jq%uwtrjint%ij%uwjhnt%ij%qtx%gtqòlwfktx%ij%htqtw%‡sjlwt•"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "B28",
        Redaccion = "G32%Zsf%ufujqjwòf%{jsij%inkjwjsyjx%ynutx%ij%gtqòlwfktx\u000FQtx%ifytx%ij%qf%ufujqjwòf%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EInwjhhnøs\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%ynut%ij%gtqòlwfkt%xts?\u000F\u00BC\u000EHqf{j%\u000F\u00BC\u000EUwjhnt\u000F\u00BC\u000EYfrföt\u000F\u00BC\u000EHfsynifi%ij%jojruqfwjx%{jsinitx\u000F\u00BC\u000EHtqtw%-f\u007Fzq1%sjlwt%t%wtot.\u000F\u000FHtsxnijwfsit%vzj%qtx%gtqòlwfktx%uzjijs%xjw%inxywngznitx%js%{fwnfx%ufujqjwòfx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "7=.\u000EIjyjwrnsj%hzæsytx%ynutx%ij%gtqòlwfktx%mf~%ij%hfif%htqtw"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "B29",
        Redaccion = "G32%Zsf%ufujqjwòf%{jsij%inkjwjsyjx%ynutx%ij%gtqòlwfktx\u000FQtx%ifytx%ij%qf%ufujqjwòf%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EInwjhhnøs\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%ynut%ij%gtqòlwfkt%xts?\u000F\u00BC\u000EHqf{j%\u000F\u00BC\u000EUwjhnt\u000F\u00BC\u000EYfrföt\u000F\u00BC\u000EHfsynifi%ij%jojruqfwjx%{jsinitx\u000F\u00BC\u000EHtqtw%-f\u007Fzq1%sjlwt%t%wtot.\u000F\u000FHtsxnijwfsit%vzj%qtx%gtqòlwfktx%uzjijs%xjw%inxywngznitx%js%{fwnfx%ufujqjwòfx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "7>.\u000EIjyjwrnsj%xn%mf~%ræx1%rjstx%t%nlzfq%hfsynifi%ij%jojruqfwjx%{jsinitx%ij%gtqòlwfktx%f\u007Fzqjx%t%wtotx"
      });
      this.miListaExamenes.Add(new Examen()
      {
        Clave = "B30",
        Redaccion = "G32%Zsf%ufujqjwòf%{jsij%inkjwjsyjx%ynutx%ij%gtqòlwfktx\u000FQtx%ifytx%ij%qf%ufujqjwòf%xts?\u000F\u00BC\u000EStrgwj\u000F\u00BC\u000EInwjhhnøs\u000F\u000FRnjsywfx%vzj%qtx%ifytx%ij%hfif%ynut%ij%gtqòlwfkt%xts?\u000F\u00BC\u000EHqf{j%\u000F\u00BC\u000EUwjhnt\u000F\u00BC\u000EYfrföt\u000F\u00BC\u000EHfsynifi%ij%jojruqfwjx%{jsinitx\u000F\u00BC\u000EHtqtw%-f\u007Fzq1%sjlwt%t%wtot.\u000F\u000FHtsxnijwfsit%vzj%qtx%gtqòlwfktx%uzjijs%xjw%inxywngznitx%js%{fwnfx%ufujqjwòfx1%rzjxywj%qtx%ifytx%hfuyzwfitx%js%zs%ifyfLwni[nj|%~%flwjlzj%zs%gtyøs%vzj%ns{tvzj%f%zs%rîytit%vzj%wjfqnhj%qt%xnlznjsyj?\u000F",
        Inciso = "85.\u000EHzjsyj%qf%hfsynifi%ij%ynutx%ij%gtqòlwfktx%ij%htqtw%‡sjlwt•%vzj%{jsinjwts%ræx%ij%655%jojruqfwjx"
      });
    }
  }
}
