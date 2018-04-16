﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleEchoBot.Model
{
    public class FakeData
    {
        private static Dictionary<string, Libros> _libros;
        private static Dictionary<string, Cursos> _cursos;

        public static Dictionary<string, Libros> Libros
        {
            get
            {
                if(_libros==null || _libros.Count==0)
                {
                    _libros = new Dictionary<string, Libros>()
                    {
                        {"Atlantis", new Libros("Atlantis, La ciudad Perdida","Greg Donegan" ,"Unica" ,"Ciencia Ficcion" ,"Epub" ,"Tres misteriosos lugares sobre la tierra: el Triángulo de las Bermudas, el Mar del Diablo en Japón y una pequeña región de Camboya. Dentro de sus límites han desaparecido aviones, se han esfumado barcos y, en Camboya, una civilización se ha extinguido. Ahora, la fuerza destructiva que está tras estos misterios ha sido revelada. Ya nos habían invadido antes. Hace diez mil años. Cuando destruyeron la Atlántida. Y ahora han regresado. Tres misteriosos lugares sobre la tierra: el Triángulo de las Bermudas, el Mar del Diablo en Japón y una pequeña región de Camboya. Dentro de sus límites han desaparecido aviones, se han esfumado barcos y, en Camboya, una civilización se ha extinguido. Ahora, la fuerza destructiva que está tras estos misterios ha sido revelada. Ya nos habían invadido antes. Hace diez mil años. Cuando destruyeron la Atlántida. Y ahora han regresado.Camboya, 1968. Eric Dane, miembro de las Fuerzas Especiales, se adentra junto a su equipo en territorio enemigo. La misión secreta que están llevando a cabo se ve interrumpida por el descubrimiento de unas ruinas, posiblemente las de la ciudad perdida de Angkor Kol Ker, y por una extraña niebla que parece tragarse todo lo que encuentra a su paso. La misión termina en forma de tragedia. Sólo Dane sobrevive. Tres décadas después la inexplicable niebla reaparece, no solamente en Camboya, también en el Triángulo de las Bermudas y en el Mar del Diablo. Es una amenaza que incumbe a las fuerzas militares más potentes. Un poder que supera nuestra ciencia y tecnología. Un enemigodespiadado que llevará a Eric Dane (y a todo el planeta) en una desesperada batalla final por la supervivencia." ,"~/Images/Atlantis.jpg")},
                        {"Axiomatico", new Libros("Axiomatico","Greg Egan" ,"Unica" ,"Ciencia Ficcion" ,"Epub" ,"Greg Egan nos brinda la que es, probablemente, la mejor antología de relatos de ciencia ficción publicada en los últimos 20 años. En este espectacular libro tenemos dieciocho relatos en los que el australiano explora con destreza y habilidad, temas como identidad personal, destino, manipulación genética, conspiraciones globales, o culpabilidad en una antología de referencia en la moderna ciencia ficción. Si alguien cree que la ciencia ficción está muerta es que no ha leído a Greg Egan, y, en particular, no ha leído esta antología. Las ideas son el motivo central de todos estos relatos. Dónde más brilla Egan es en los cuentos que tratan sobre el problema de la personalidad humana. Axiomático, Ver y Cercanía son otras tantas visiones de cómo nuestra biología y la estructura neurológica de nuestros cerebros dan forma a quiénes somos." ,"~/Images/Axiomatico.jpg")},
                        {"Blasfemia", new Libros("Blasfemia","Duglas Preston" ,"Unica" ,"Ciencia Ficción, Intriga, Techno-thriller" ,"Epub" ,"El supercolisionador más grande del mundo, encerrado en una montaña de Arizona, fue construido para revelar los secretos del momento mismo de la creación: el Big Bang. El anillo es la máquina más cara jamás creada por la humanidad, a cargo del superordenador más potente del mundo. ¿Divulgará ese anillo los misterios de la creación del universo? ¿O, como algunos predicen, hará que la Tierra sea succionada por un mini agujero negro? ¿O es el anillo un intento satánico, que como un poderoso tele evangelista condena, desafía a Dios Todopoderoso por el propio trono del Cielo? Doce científicos bajo la dirección de Hazelius se envían a la remota montaña para encenderlo, y lo que descubren debe ser ocultado al mundo a toda costa. Wyman Ford, ex monje y agente de la CIA, es enviado para arrancar su secreto, un secreto que, o bien va a destruir el mundo… o a salvarlo. La cuenta atrás ha comenzado…" ,"~/Images/Blasfemia.jpg")},
                        {"Condicion", new Libros("La Condicion Humana Actual","Erich Fromm" ,"Unica" ,"Ensayo, Psicología" ,"Epub" ,"Este libro examina con detalle algunos temas de fundamental importancia para el hombre de hoy (el sexo, el psicoanálisis y la psicología, la revolución y la paz…), a través de un análisis pormenorizado de las perspectivas de progreso que abrió la caída del mundo medieval –destrucción que permitió al hombre occidental la posibilidad histórica de un progreso sin límites, de una auténtica realización de la utopía– y de las causas de esta trayectoria inesperada. El hecho es que las sociedades modernas requieren un determinado tipo de hombre para funcionar y el industrialismo moderno ha tenido éxito en la producción de esta clase de hombre: es el autómata, el hombre enajenado. El ideal de este hombre-autómata, añade Fromm, es que todo transcurra de acuerdo con el viejo eslogan de Kodak: «Usted apriete el botón, nosotros hacemos el resto». Su razón se deteriora a la vez que crece su inteligencia. De este modo, y como dice el propio Fromm, lo más urgente es huir de esta situación y crear un nuevo hombre que deberá ser «temerario, valiente, imaginativo, capaz de sufrir y gozar», pero cuyas fuerzas estarán «al servicio de la vida, no de la muerte»." ,"~/Images/Condicion.jpg")},
                        {"Leviatan", new Libros("El Despertar Del Leviatan","James S. A. Corey" ,"Unica" ,"Ciencia Ficción, Novela" ,"Epub" ,"La humanidad ha colonizado el Sistema Solar: Marte, la Luna, el cinturón de asteroides y más allá, pero las estrellas aún están fuera de nuestro alcance. Jim Holden es segundo de a bordo de un transportador de hielo que realiza misiones entre los anillos de Saturno y las estaciones mineras del Cinturón. Cuando su tripulación y él se topan con la Scopuli, una nave abandonada, descubren un secreto que desearían no haber encontrado. Un secreto por el que alguien sería capaz de matar, matar a una escala que Jim y su tripulación no imaginan. La guerra en el Sistema Solar está a punto de comenzar, a menos que sean capaces de descubrir quién abandonó la nave y por qué. El inspector Miller busca a una chica. Una chica entre mil millones, pero los padres de ella son gente adinerada, y el dinero lo es todo. Cuando las pistas lo llevan a la Scopuli y a Holden, un simpatizante de los rebeldes, se da cuenta de que aquella chica quizá sea la clave de todo. Holden y Miller deben atar los cabos entre el gobierno de la Tierra, los revolucionarios de los planetas exteriores y corporaciones secretas, y lo tienen todo en su contra. Pero en el Cinturón hay otras reglas, y una pequeña nave puede cambiar el destino del universo." ,"~/Images/Leviatan.jpg")},
                        {"Colonia", new Libros("La Colonia Perdida","John Scalzi" ,"III de Fuerzas de Defenza Coloniales" ,"Ciencia Ficcion" ,"Epub" ,"John Perry y Jane Sagan han encontrado la paz junto a su hija adoptiva Zoë en el planeta colonial Huckleberry. Es una buena vida, pero sienten que les falta… algo. Por eso, cuando se les propone liderar una nueva colonia, John y Jane no pueden resistir la tentación de explorar el universo una vez más. Pero cuando los colonos son abandonados en un planeta desconocido, Perry descubre que nada es lo que parece. Él y su nueva colonia son simples peones en la confrontación entre la Unión Colonial humana y la confederación alienígena denominada el Cónclave, que pretende acabar con la colonización humana. Mientras la partida se decide, Perry deberá luchar por mantener a sus colonos con vida ante las amenazas de ambos bandos en un planeta que esconde sus propios secretos, a la vez que intenta prevenir una guerra que no sólo amenaza con engullir su nuevo hogar, sino que también promete la destrucción de toda la Unión Colonial. Si Stephen King hubiera intentado escribir ciencia ficción, tendría suerte de ser la mitad de entretenido que John Scalzi. The Dallas Morning News" ,"~/Images/Colonia.jpg")},
                        {"Zoe", new Libros("La Historia de Zoe","John Scalzi" ,"IV de Fuerzas de Defenza Coloniales" ,"Ciencia Ficcion" ,"Epub" ,"¿Cómo cuentas tu participación en el relato más grande de la historia? Lo pregunto porque es lo que tengo que hacer. Soy Zoë Boutin-Perry: miembro de una colonia aislada en un letal mundo pionero. Sagrado icono de una raza de alienígenas. Jugadora y peón en una partida de ajedrez interestelar para salvar a la humanidad, o para verla caer. Testigo de la historia. Amiga. Hija. Humana. Diecisiete años. Todos en la Tierra conocen la historia de la que formo parte. Pero no conocen mi propia historia: cómo hice lo que hice, lo que tuve que hacer, no sólo para seguir viva, sino para que vosotros también siguierais con vida. Ahora me dispongo a contarlo, todo, de la única forma que sé: directa y sincera, para que sintáis lo que yo sentí; la alegría y la incertidumbre, el pánico y el asombro, la desesperación y la esperanza. Todo a través de mis ojos. Ya conocéis esta historia. Pero no la conocéis toda." ,"~/Images/Zoe.jpg")},
                        {"Guardia", new Libros("La Vieja Guardia","John Scalzi" ,"I de Fuerzas de Defenza Coloniales" ,"Ciencia Ficcion" ,"Epub" ,"Tras haber vivido una vida relativamente tranquila en la Tierra y el mismo día en que cumplen setenta y cinco años, 1.022 ancianos se enrolan en las Fuerzas de Defensa Coloniales, el ejército que lucha por la supervivencia de la humanidad en el universo. La vida en la Tierra transcurre sin demasiados contratiempos. Sin embargo, en el universo se está librando una guerra sin cuartel por los últimos planetas todavía deshabitados de la galaxia. El ejército que defiende la causa de la humanidad está formado por ancianos. Ancianos a los que se les da el cuerpo de un joven de veinte años. Sin perder un ápice de los conocimientos y experiencias de su vida anterior, sus nuevos cuerpos les harán redescubrir sensaciones que la vejez había sumido en el olvido, sentirán de nuevo el vigor de la juventud, la atracción, el deseo y el sexo recobrarán sentido. Sin embargo, el precio que pagarán por semejante regalo es alto: viajarán a un lugar remoto e inhóspito donde lo único importante será luchar y tratar de sobrevivir. Y nunca se les dará la posibilidad de regresar a la Tierra. Apasionante y de una originalidad sorprendente. Sin los sermones de Tropas del espacio y con mucho más sexo que La guerra interminable. Divertida, triste, auténtica. Cory Doctorow John Scalzi nació en California y actualmente reside en Ohio. Es un prolífico columnista y escritor de ensayo. Entre sus libros destacan The Roghe Guide to the Universe y The Book of the Dumb. The Whatever es uno de los más visitados en la red. La vieja guardia, que obtuvo una nominación al premio Hugo en 2006 y fue galardonada con el premio Campbel ese mismo año en la categoría de mejor autor novel, es su primera novela." ,"~/Images/Guardia.jpg")},
                        {"Brigadas", new Libros("Las Brigadas Fantasma","John Scalzi" ,"II de Fuerzas de Defenza Coloniales" ,"Ciencia Ficcion" ,"Epub" ,"Las Brigadas Fantasma son las Fuerzas Especiales de las Fuerzas de Defensa Coloniales; tropas de élite creadas a partir del ADN de los muertos y transformadas en soldados perfectos para las operaciones más duras. Son jóvenes, son rápidos y fuertes y carecen de escrúpulos humanos. El universo es un lugar peligroso para la humanidad y está a punto de serlo mucho más, ya que tres razas alienígenas se han aliado contra los humanos. Cuentan con un importante aliado: el científico militar Charles Boutin, que ha traicionado a la humanidad y ha desvelado los mayores secretos de las FDC. Para vencer, las FDC deberán averiguar qué ha llevado a Boutin a cometer semejante acto. La clave para resolver este enigma se llama Jared Dirac; un híbrido superhumano, creado a partir del ADN de Boutin y cuyo cerebro contiene la memoria del traidor. Pero el trasplante de memoria falla y Jared es trasladado a las Brigadas Fantasma. Allí se convierte en un soldado perfecto, hasta que los recuerdos de Boutin comienzan a manifestarse. Jared emprenderá entonces una búsqueda desesperada de su «padre» para obtener respuestas, pero el tiempo corre en su contra: la alianza está preparando su ofensiva y planean cosas peores que la mera derrota militar de la humanidad." ,"~/Images/Brigadas.jpg")},
                        {"Marca Odin", new Libros("La Marca de Odin","Xavi Marce" ,"I de Marca de Odin" ,"Ciencia Ficcion" ,"Epub" ,"La Marca de Odín: El despertar. Edición LITE" ,"~/Images/Marca Odin.jpg")},
                        {"Mundo", new Libros("El Mundo Es Uno","Arthur C. Clarcke" ,"Unica" ,"Ensayo,Tecnologia" ,"Epug" ,"Un fascinante libro que abarca la historia de la tecnología aplicada a las comunicaciones desde mediados del siglo pasado hasta la actualidad. Con el nacimiento del telégrafo en 1858, Estados Unidos y Gran Bretaña quedaron unidos por un tendido de cables de cobre que atravesaba el Atlántico; ejemplo seguido por otros países de Europa, Asia y Oceanía, que establecieron nuevos vínculos gracias al ingenio telegráfico. Se sucedieron nuevas búsquedas, fracasos y hallazgos, como el teléfono y la radio, en el campo de las comunicaciones, hasta llegar, tras la Segunda Guerra Mundial, a la comunicación por satélite. Clarke abunda en explicaciones respecto al modo en que se realizaron los lanzamientos del Echo, Telstar, Sycon y los Intelsat; explica los servicios que prestan los satélites y se concentra, finalmente, en la descripción del empleo de las fibras ópticas. El mundo es uno constituye un interesante recorrido por los intentos y especulaciones, no sólo de técnicos y científicos, sino de escritores, como el mismo Clarke, en su afán por disolver las fronteras que separan los distintos mundos." ,"~/Images/Mundo.jpg")},
                        {"Prance", new Libros("Prance, El Ultimo Guardian","Jaun Moro" ,"I de El Ultimo Guardian" ,"Ciencia Ficcion,Novela" ,"Epub" ,"En unas pruebas militares, el Pentágono descubre un ovni que no puede abrir. Mark T. lo consigue y descubre que contiene dos terribles secretos que nos llevarán a la extinción. El ovni permanecía oculto pero es desenterrado. Está controlado por una I.A. (Lara). Ante la imposibilidad de abrirla a la fuerza, contratan a Mark T. de la NASA para convencerla de que les permita acceder a su interior. Tras muchos intentos fallidos, consigue que la compuerta de carga (controlada por otra I.A. de menor rango) acceda a abrirse. Lara contacta con Mark fuera de la base donde la custodian, ya que una vez finalizado su trabajo es expulsado, y le revela la historia de su dueño, la terrible guerra que llevó al exterminio de su pueblo y la amenaza latente de tan implacable enemigo. También le explica que la apertura de la compuerta conllevará la extinción de la vida de la Tierra. La situación se convierte en una cuenta atrás para localizar al tripulante. Juan Moro consigue generar una constante intriga y suspense durante toda la obra. Está escrita y contada de una forma original tal y como la contaría una máquina (una I.A.) consiguiendo llevar al expectador a otros mundos y civilizaciones." ,"~/Images/Prance.jpg")},
                        {"Clanes", new Libros("El Señor De Los Clanes","Christie Golden" ,"III de Warcraft" ,"Aventuras, Fantástico, Novela" ,"Epub" ,"El señor de los clanes . El mundo de Azeroth, envuelto en la brumosa mortaja del pasado, estaba poblado de fabulosas criaturas de todo tipo. Elfos misteriosos y fornidos enanos caminaban entre las tribus del hombre en relativa paz y armonía... hasta que la llegada del demoniaco ejército conocido como la Legión Ardiente destruyó para siempre la tranquilidad del mundo. Ahora, orcos, dragones, trasgos y trolls pugnan por el control de los dispersos reinos en guerra; su lucha forma parte de un ambicioso y malévolo plan que determinará el destino del mundo de WarCraft. Esclavo, gladiador, chamán, señor de la guerra, todo esto ha sido el enigmático orco llamado Thrall, criado desde su infancia por crueles amos humanos que pretendían convertirlo en su perfecto peón. El salvajismo de su corazón y la astucia adquirida durante su aprendizaje impulsaron a Thrall a perseguir un destino que aún no alcanzaba a comprender; a renunciar a sus ataduras para volver a descubrir las antiguas tradiciones de su pueblo. Ahora, por fin puede narrarse el tumultuoso relato del viaje de su vida: una saga de honor, odio y esperanza. El señor de los clanes. Un original relato de magia, guerra y heroísmo basado en el premiado juego de ordenador, éxito en ventas, de Blizzard Entertainment." ,"~/Images/Clanes.jpg")},
                        {"Simulacron 3", new Libros("Simulacron 3","Daniel F. Galouye" ,"Unica" ,"Ciencia Ficcion" ,"Epub" ,"El mundo del futuro... su destino estaba controlado por una máquina enorme e inhumana: SIMULACRON-3 El mundo del futuro basaba su política sobre la opinión pública, pero comprendió que los encuestadores eran demasiado lentos, inexactos e inconsistentes para poder basar en ellos una sociedad bien organizada. Así que los investigadores científicos como Morton Lynch, Hannon Muller y Douglas Hall construyeron un simulador electrónico... en el cual metían análogos subjetivos, para obtener resultados de las reacciones humanas... Entonde Hall descubrió que su mundo no era más que un simulador de medio ambiente, gobernado por un mundo tan enorme para él, como el suyo lo era para el diminuto mundo de su simulador..." ,"~/Images/Simulacron 3.jpg")},
                        {"Togar", new Libros("Togar","Juan Moro" ,"II de El último guardián" ,"Ciencia Ficción, Novela" ,"Epub" ,"Tógar es la trepidante continuación de Prance, el último Guardián. En ella, el descubrimiento, durante unas pruebas militares, de una nave alienígena enterrada, dejó al descubierto la existencia de otras civilizaciones mucho más avanzadas que la nuestra. El Doctor Mark Temple, sabedor de que la nave era un reducto del ejército del Bien, vencido tras la Gran Batalla Final y consciente de los peligros que entrañaría abrirla, fue apartado de la investigación por la NASA militar. En su huída, Mark y su mujer, la Doctora Sen, deciden difundir sus trascendentes averiguaciones por medio de un libro, cuya lectura hará resurgir al derrotado Prance de sus cenizas. A pesar de las dificultades, será desde la Tierra donde, una vez recuperada su nave, comenzará a gestar su retorno. Un improbable regreso a un Universo dominado por sus antaño compañeros, Trash y Tógar, ahora, acérrimos enemigos." ,"~/Images/Togar.jpg")},
                        {"Trash", new Libros("Trash","Juan Moro" ,"III de El último guardián" ,"Ciencia Ficción, Novela" ,"Epub" ,"El Príncipe Prance, tras su prolongado paso por la Tierra, logra una nueva perspectiva sobre la condición de sus habitantes, sus carencias y la conveniencia ineludible de reconducirlos hacia el Bien. Por otro lado, descubre que su propio destino había sido meticulosamente planificado por la raza Yúrem en connivencia con su difunta esposa y algunos de sus más leales amigos, también fallecidos; así, puede reunificar sus Ejércitos y prepararse para derrotar a Trash. Si bien, habrá de urdir y solapar estrategias de lo más dispares, ya que la superioridad aplastante del Ejército del Mal le obliga un descartar un enfrentamiento frontal." ,"~/Images/Trash.jpg")},
                        {"Trueno", new Libros("Trueno Rojo","John Valery" ,"Unica" ,"Ciancia Ficcion" ,"Epub" ,"Manny García regenta un decrépito motel próximo a Cabo Cañaveral. Dak, su mejor amigo, trabaja en un concesionario y comparte con él su obsesión por el espacio. Ambos contemplan junto a sus novias el despegue de la primera misión tripulada de la NASA a Marte. Demasiado tarde, pues una misión china está ya en camino; esa misma noche, el accidentado encuentro de los cuatro amigos con el alcohólico ex astronauta Travis Broussard cambiará las cosas. Su primo es un genio excéntrico que ha descubierto una nueva fuente de energía. Juntos emprenderán una carrera contra el reloj por completar el proyecto más ambicioso que jamás habrían imaginado: construir desde cero el Trueno Rojo, una nave espacial para viajar a Marte. Una lectura refrescante que nos devuelve a la esencia de la edad de oro de la cf. Una historia llena de ironía y optimismo sobre las aspiraciones de la carrera espacial y las esperanzas de una nueva generación." ,"~/Images/Trueno.jpg")},
                        {"Empezar", new Libros("Volver A Empezar","Ken Grimwood" ,"Unica" ,"Ciencia Ficcion" ,"Epub" ,"Un clásico de los viajes en el tiempo que lanza una pregunta provocadora: ¿qué pasaría si pudieras vivir tu vida otra vez, acordándote de los errores cometidos en el pasado? A Jeff Winston, de 43 años, se le da esta oportunidad varias veces. Atrapado en un matrimonio aburrido y un trabajo sin salidas, muere en 1988 y se despierta en 1963, con 18 años, en el dormitorio de su antigua universidad. Todo es igual que antes, pero con una gran diferencia: Jeff sabe lo que le depara el futuro. Sabe quién ganará cada partido, cada competición nacional, y hasta cómo hacer dinero en Wall Street. Lo único que ignora es por qué ha sido elegido para volver a empezar su vida, ni cuántas veces deberá ganar, y perder, todo lo que tiene.Y a la misma edad en que murió por primera vez vuelve a fallecer. Así sucesivamente a lo largo de varias ocasiones,estas repeticiones se producen tras su muerte por infarto, siempre en el mismo momento, y hacen que Jeff pueda experimentar varias vidas distintas o, para expresarlo de otro modo, tomar caminos distintos en su vida. Varias vidas más tarde, y con la sapiencia de sus otras experiencias, Jeff conoce a una mujer que está pasando por el mismo trance y tras enamorarse de ella vive de nuevo hasta su muerte. Pero la historia sigue repitiéndose, y aunque se encuentran en todas las vidas, cada vez es más difícil adaptarse a la situación." ,"~/Images/Empezar.jpg")}
                    };
                }
                return _libros;
            }
        }

        public static Dictionary<string, Cursos> Cursos
        {
            get
            {
                if(_cursos == null || _cursos.Count==0)
                {
                    _cursos = new Dictionary<string, Cursos>()
                    {
                        {"Unity",new Cursos("La guía definitiva del desarrollo de videojuegos con Unity","Jonathan Weinberger,Authorized Unity Instructor","Si estás interesado en desarrollar increíbles juegos con calidad comercial que pueden jugarse en varias plataformas, entonces este curso es para ti. Este curso es el único de su tipo aprobado por Unity Technologies en Udemy. ¿Qué mejor manera de aprender a desarrollar videojuegos en Unity que con el curso autorizado por ellos? La guía definitiva del desarrollo de videojuegos con Unity te da una introducción a Unity y a los fundamentos de programación con C#. El curso luego se sumerge en el desarrollo de tu primer juego 2D y tu primer juego 3D. Descubrirás cómo resaltar tus juegos del resto al pulirlos con las últimas características de Unity, incluidos los efectos de post procesamiento y el sistema de animación.","Clases:132","11 Horas","~/Images/Unity.jpg") },
                        {"Kotlin",new Cursos("Android O - Curso de Desarrollo de Aplicaciones con Kotlin","Aldo Olivares, Application Developer","Bienvenidos al nuevo curso Android O - Curso de Desarrollo de Aplicaciones con Kotlin. Este es un nuevo curso enfocado a programadores android donde les enseñare todo lo necesario para aprender a programar sus primeras aplicaciones con kotlin ","Clases:144","10 Horas","~/Images/Kotlin.jpg") },
                        {"Node",new Cursos("Node JS Training and Fundamentals","Hassan Azimi, Software Engineer and Web Developer","Node JS a powerful tool for controlling web servers, building applications, and creating event-driven programming and it brings JavaScript, a language familiar to all web developers, into an environment independent of web browsers. Learn all about Node JS and start creating JavaScript applications in this course with me. I show how to install Node JS on Mac, Windows, and dives deep into its modules and Express framework for app development. Learn how to unit test your code, start sessions on web servers, stream data, and create simple command-line tools.","Clases:32","4.5 Horas","~/Images/Node.jpg") },
                        {"Web",new Cursos("HTML5, CSS3, JavaScript, jQuery, AJAX,  PHP y MySQL","Juan Pablo De la torre Valdez, Freelance Web Developer and Owner of Easy-WebDev","Este curso esta lleno de tips y técnicas, además de la creación de un sitio Web real con funciones muy avanzadas y un área de administración para hacer un sitio 100% dinámico. Además de las tecnologías anteriores, crearemos galerías, formularios, validaciones, un carrito en línea con cotizador, registros a la base de datos, sistema de inicio de sesión, agregar la información dinámicamente desde la Base de Datos MySQL y mucho más!","Clases:539","47 Horas","~/Images/Web.jpg") },
                        {"Docker",new Cursos("Iniciando con Containers en Docker","Jair Gómez, Microsoft MVP","La idea detrás de Docker es crear contenedores ligeros y portables para las aplicaciones software que puedan ejecutarse en cualquier máquina con Docker instalado, independientemente del sistema operativo que la máquina tenga por debajo, facilitando así también los despliegues. ¿Cuáles son sus beneficios? Docker es una herramienta diseñada para beneficiar tanto a desarrolladores, testers, como administradores de sistemas, en relación a las máquinas, a los entornos en sí donde se ejecutan las aplicaciones software, los procesos de despliegue.","Clases:29","2.5 Horas","~/Images/Docker.jpg") }
                    };
                }
                return _cursos;
            }
        }
    }
}