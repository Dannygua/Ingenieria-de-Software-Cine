create database Cine

create table Usuarios (
NameUse varchar (50) primary key,
Pass varchar (50) ,
Nombres varchar (100),
Apellidos varchar (100),
Correo varchar (100),
fechanacimiento date,
TipoUsuario varchar (50),
Compras int

)

create table Peliculas (
CodigoPe int primary key identity not null,
NombrePe varchar (50) ,
WebPe varchar (100),
DirectoresPe varchar (100),
ActoresPe varchar (100),
DescripcionPe varchar (500),
Ventas int, 
Horarios time, 
ImagenPe varchar (100),
CategoriaPe varchar (50)  

)


create table Combos (
CodigoCo int primary key identity not null,
NombreCo varchar (100) ,
PrecioCo money,
ContenidoCo varchar (200),
Ventas int,
ImagenCo varchar (100)
)

drop table Combos


insert into Usuarios values ('Kirineko','12345','Danny Alexander', 'Guañuna Ajila', 'Dannyajila2000@hotmail.com','1998-07-27','Administador')
insert into Usuarios values ('Kuroke','12345','Diana Elena', 'Margeorie Minango', 'DianaE2000@hotmail.com','1998-05-12','Cliente')

insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('JOKER','http://www.jokermovie.net/','Todd Phillips','Joaquin Phoenix, Robert De Niro, Zazie Beetz', 'Joker mostrará por primera vez los orígenes del icónico archienemigo por excelencia de Bruce Wayne/Batman. La historia sigue de cerca la vida de Arthur Fleck, un hombre con problemas psiquiátricos que vivirá una serie de acontecimientos que le harán convertirse en uno de los grandes villanos de DC Comics. El Príncipe Payaso del Crimen se cruzará en el camino de Thomas Wayne y se acercará a su hijo, el futuro Caballero Oscuro en su versión joven.', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C1.jpg','Estreno')
insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('MALEFICA 2','https://disneylatino.com/','Joachim Ronning','Angelina Jolie, Elle Fanning, Michelle Pfeiffer', 'Una nueva aventura de fantasía. Varios años después, continúa la relación entre la villana Maléfica y la princesa Aurora. El complejo vínculo entre la malvada hada de grandes cuernos y la joven que será la futura reina evoluciona, mientras ambas hacen nuevas alianzas y se enfrentan a diferentes adversarios, sin olvidarse de proteger a las criaturas mágicas que residen en su reino.', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C2.jpg','Estreno')
insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('PLAYMOBIL','PLAYMOBIL','Lino DiSalvo','Joaquin Phoenix, Robert De Niro, Zazie Beetz', 'La joven Marla se embarca en una épica aventura para encontrar a su hermano pequeño Charlie . El único problema es que tanto ella como él han desaparecido de su realidad y se han adentrado en el asombroso mundo animado de Playmobil. Ahora miden 7,5 centímetros y tienen que convivir con vikingos, agentes secretos, vaqueros, monstruos gigantescos, robots, hadas mágicas, piratas, motoristas, ardillas y dinosaurios.', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C3.jpg','Estreno')
insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('ABOMINABLE','https://www.facebook.com/AbominableTheMovie','Jill Culton, Todd Wilderman','Angelina Jolie, Elle Fanning, Michelle Pfeiffer', 'Yi es una adolescente más en la enorme ciudad de Shanghai. Un día, se encuentra a un joven yeti en la azotea de su edificio. La supuestamente abominable criatura, que se ha escapado del laboratorio donde estaba encerrado, está siendo buscada por toda la ciudad. Junto con sus ingeniosos amigos Jin y Peng, Yi decide ayudarle a huir, le bautizan como Everest y los cuatro se embarcan en una épica aventura para reunir a la mítica criatura con su familia en el pico más alto del mundo.', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C4.jpg','Estreno')
insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('RAMBO ULTIMA MISION','https://rambo.movie/','Adrian Grunberg','Sylvester Stallone, Paz Vega, Marco de la O, Sergio Peris-Mencheta', 'JCuatro décadas después, el veterano de Vietnam y paciente con TEPT (Trastorno de estrés postraumático) regresa a su rancho familiar de Arizona. John Rambo, uno de los mayores héroes de acción de todos los tiempos, deberá enfrentarse a su pasado y desenterrar sus despiadadas habilidades de combate para vengarse en una misión final, emprendiendo así un viaje mortal, justiciero y sin retorno.', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C5.jpg','Estreno')
insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('AZULES TURQUESAS','AZULES TURQUESAS','Joachim Ronning','Angelina Jolie, Elle Fanning, Michelle Pfeiffer', 'A veces, los espacios que parecen ser la salvación de uno terminan siendo los que más nos oprimen. Esta es una película sobre las drogas y el camino que Isabella, de 28 años, emprende para dejar sus adicciones. Azules turquesas, título homónimo de una canción de Lisandro Aristimuño, retrata desde adentro a los centros de rehabilitación y sus prácticas médicas, llenas de engaños, violencia, manipulación y descuido profesional.', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C6.jpg','Estreno')
insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('AD ASTRA','http://www.jokermovie.net/','James Gray','Brad Pitt, Tommy Lee Jones, Ruth Negga', 'El veterano astronauta Clifford McBride desapareció hace más de 20 años en una misteriosa y patriótica misión en el espacio en busca de vida extraterrestre en el planeta Neptuno. Su hijo Roy, también astronauta, no ha superado su misteriosa pérdida y aún guarda la esperanza de poder volver a verle. La NASA aprovechará este anhelo y motivación de Roy para ponerle al frente de una arriesgada misión espacial', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C7.jpg','Estreno')
insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('BODA SANGRIENTA','http://www.foxsearchlight.com/readyornot/','Tyler Gillett, Matt Bettinelli Olpin','Samara Weaving, Adam Brody, Mark O Brien', 'Durante su noche de bodas, una novia recibe una extraña invitación de la rica y excéntrica familia de su marido. Todo toma un giro siniestro cuando la obligan a participar en una tradición ancestral, que se convierte en un juego letal en el que tendrá que luchar por la superviviencia.', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C8.jpg')

insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('Proyecto Géminis','','Ang Lee','Mary Elizabeth Winstead, Will Smith', 'Un innovador thriller de acción protagonizado por Will Smith como Henry Brogan, un asesino por encargo que comienza a ser perseguido por un hombre más joven que él y que parece predecir cada uno de sus movimientos.', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C10.jpg','Proximo Estreno')
insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('Terminator: Destino Oscuro','','Tim Miller','Mackenzie Davis, Arnold Schwarzenegger', 'La nueva película marca el retorno de Linda Hamilton como Sarah Connor, quien hoy sale al auxilio de una muchacha perseguida por un nuevo Terminator de metal líquido. Y a pedido de la misma Sarah, el viejo T-800 se uniría a la batalla.', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C11.jpg','Proximo Estreno')
insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('Zombieland 2','',' Ruben Fleischer','Emma Stone, Abigail Breslin', 'Los cazadores de zombis viajan desde la Casa Blanca hasta el corazón de los Estados Unidos, donde tendrán que defenderse de nuevas clases de muertos vivientes que han evolucionado. Mientras intentan salvar el mundo, los miembros de la pandilla también tendrán que aprender a convivir.', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C12.jpg','Proximo Estreno')
insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('Los Angeles de Charlie','','Elizabeth Banks','Naomi Scott, Elizabeth Banks', 'Vuelven a la gran pantalla las tres detectives conocidas como Los Ángeles de Charlie. Tres mujeres que dejaron el cuerpo de Policía para trabajar en arriesgadas misiones para la agencia de detectives propiedad del misterioso Charles Townsend, más conocido como Charlie.', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C13.jpg','Proximo Estreno')
insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('Ford vs Ferrari','','James Mangold','Matt Damon, Christian Bale', 'Se centra en un excéntrico y decidido equipo americano de ingenieros y diseñadores, liderados por el visionario automovilístico Carroll Shelby (Damon) y su conductor británico Ken Miles (Bale). Henry Ford II y Lee Iacocca les dan la misión de construir desde cero un nuevo automóvil con el fin de derrocar el dominio de Ferrari en el Campeonato del Mundo de Le Mans de 1966.', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C14.jpg','Proximo Estreno')
insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('Frozen 2','','Chris Buck, Jennifer Lee','Jonathan Groff, Kristen Bell', 'La reina Elsa, su hermana Anna, Kristoff, Olaf y Sven se embarcan en un nuevo viaje al interior del bosque para descubrir la verdad sobre un antiguo misterio de su reino.', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C15.jpg','Proximo Estreno')
insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('Star Wars: Capítulo IX','','J.J. Abrams','Adam Driver, Daisy Ridley', 'Lucasfilm y el director J.J. Abrams unen sus fuerzas una vez más para llevar a los espectadores a un viaje épico con STAR WARS: EL ASCENSO DE SKYWALKER. En esta fascinante conclusión de la saga Skywalker, nacerán nuevas leyendas y se librará la batalla final por la libertad.', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C16.jpg','Proximo Estreno')
insert into Peliculas (NombrePe ,WebPe ,DirectoresPe ,ActoresPe ,DescripcionPe ,ImagenPe,CategoriaPe) values ('Jumanji: El Siguiente Nivel','','Jake Kasdan','Dwayne Johnson, Jack Black', 'En esta ocasión, los jugadores vuelven al juego, pero sus personajes se han intercambiado entre sí, lo que ofrece un curioso plantel: los mismos héroes con distinta apariencia. Pero, ¿dónde está el resto de la gente? Los participantes sólo tienen una opción: jugar una vez más a esta peligrosa partida para descubrir qué es realmente lo que está sucediendo.', 'E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\C17.jpg','Proximo Estreno')


insert into Combos (NombreCo ,PrecioCo ,ContenidoCo ,ImagenCo,) values ('Combo 1',7.60,' 1 Canguil mediano, 1 Bebida mediana, 1 Hot Dog','E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\T1.jpg')
insert into Combos (NombreCo ,PrecioCo ,ContenidoCo ,ImagenCo) values ('Combo 2',7.60,' 1 Canguil mediano, 1 Bebida mediana, 1 Nacho','E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\T2.jpg')
insert into Combos (NombreCo ,PrecioCo ,ContenidoCo ,ImagenCo) values ('Combo 3',12.90,' 1 Canguil mediano, 2 Bebidas mediana, 2 Hot Dogs o 2 Nachos o 1 Hot Gog y 1 Nacho','E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\T3.jpg')
insert into Combos (NombreCo ,PrecioCo ,ContenidoCo ,ImagenCo) values ('Combo 4',7.60,' 1 Canguil mediano, 2 Bebidas mediana','E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\T4.jpg')
insert into Combos (NombreCo ,PrecioCo ,ContenidoCo ,ImagenCo) values ('Combo 5',9.15,' 1 Canguil mediano, 1 Bebida mediana, 1 Mega Nacho','E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\T5.jpg')
insert into Combos (NombreCo ,PrecioCo ,ContenidoCo ,ImagenCo) values ('Combo 6',9.15,' 1 Canguil mediano, 1 Bebida mediana, 1 Mega Hot Dog','E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\T6.jpg')
insert into Combos (NombreCo ,PrecioCo ,ContenidoCo ,ImagenCo) values ('Combo Infantil',5.10,' 1 Canguil infantil, 1 Bebida infantil, 1 Dulce','E:\Politecnica\Tecnicas\TecnicasProyecto4\TecnicasProyecto4\imagenes\T7.jpg')



select * from Peliculas
