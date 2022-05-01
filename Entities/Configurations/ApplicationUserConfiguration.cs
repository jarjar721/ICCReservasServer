using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configurations
{
    internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("AspNetUsers");
            builder.Property(property => property.Status).HasDefaultValue(1);

            builder.HasData(
                new ApplicationUser { 
                    Names = "Nayi",
                    LastNames = "Adorno",
                    Email = "nadorno@cumbrescaracas.edu.ve",
                    UserName = "nadorno",
                    NormalizedUserName = "nadorno".ToUpper(),
                    NormalizedEmail = "nadorno@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser { 
                    Names = "Claudia",
                    LastNames = "Aguilar",
                    Email = "caguilar@cumbrescaracas.edu.ve",
                    UserName = "caguilar",
                    NormalizedUserName = "caguilar".ToUpper(),
                    NormalizedEmail = "caguilar@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser { 
                    Names = "Greysa",
                    LastNames = "Aguilar",
                    Email = "gaguilar@cumbrescaracas.edu.ve",
                    UserName = "gaguilar",
                    NormalizedUserName = "gaguilar".ToUpper(),
                    NormalizedEmail = "gaguilar@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser { 
                    Names = "Melissa",
                    LastNames = "Alcala",
                    Email = "malcala@cumbrescaracas.edu.ve",
                    UserName = "malcala",
                    NormalizedUserName = "malcala".ToUpper(),
                    NormalizedEmail = "malcala@cumbrescaracas.edu.ve".ToUpper()
                }, 
                new ApplicationUser
                {
                    Names = "José Antonio",
                    LastNames = "Alemán",
                    Email = "jaleman@cumbrescaracas.edu.ve",
                    UserName = "jaleman",
                    NormalizedUserName = "jaleman".ToUpper(),
                    NormalizedEmail = "jaleman@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "German",
                    LastNames = "Andara",
                    Email = "gandara@cumbrescaracas.edu.ve",
                    UserName = "gandara",
                    NormalizedUserName = "gandara".ToUpper(),
                    NormalizedEmail = "gandara@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Verónica",
                    LastNames = "Angulo",
                    Email = "loumarangulo@gmail.com",
                    UserName = "loumarangulo",
                    NormalizedUserName = "loumarangulo".ToUpper(),
                    NormalizedEmail = "loumarangulo@gmail.com".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Yuleima",
                    LastNames = "Ardila",
                    Email = "yardila@cumbrescaracas.edu.ve",
                    UserName = "yardila",
                    NormalizedUserName = "yardila".ToUpper(),
                    NormalizedEmail = "yardila@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Leonardo",
                    LastNames = "Arellano",
                    Email = "larellano@legionaries.org",
                    UserName = "larellano",
                    NormalizedUserName = "larellano@legionaries.org".ToUpper(),
                    NormalizedEmail = "larellano".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Martina",
                    LastNames = "Arismendi",
                    Email = "marismendi@cumbrescaracas.edu.ve",
                    UserName = "marismendi",
                    NormalizedUserName = "marismendi@cumbrescaracas.edu.ve".ToUpper(),
                    NormalizedEmail = "marismendi".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Edilbeck",
                    LastNames = "Armas",
                    Email = "earmas@cumbrescaracas.edu.ve",
                    UserName = "earmas",
                    NormalizedUserName = "earmas@cumbrescaracas.edu.ve".ToUpper(),
                    NormalizedEmail = "earmas".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Anabell",
                    LastNames = "Armas De Hanna",
                    Email = "aarmas@cumbrescaracas.edu.ve",
                    UserName = "aarmas",
                    NormalizedUserName = "aarmas".ToUpper(),
                    NormalizedEmail = "aarmas@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Yldith",
                    LastNames = "Arrayago",
                    Email = "yarrayago@cumbrescaracas.edu.ve",
                    UserName = "yarrayago",
                    NormalizedUserName = "yarrayago".ToUpper(),
                    NormalizedEmail = "yarrayago@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Ivana",
                    LastNames = "Avendaño",
                    Email = "iavendano@cumbrescaracas.edu.ve",
                    UserName = "iavendano",
                    NormalizedUserName = "iavendano".ToUpper(),
                    NormalizedEmail = "iavendano@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Jhonny",
                    LastNames = "Avila",
                    Email = "javila@cumbrescaracas.edu.ve",
                    UserName = "javila",
                    NormalizedUserName = "javila".ToUpper(),
                    NormalizedEmail = "javila@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Alfredo",
                    LastNames = "Bedetti",
                    Email = "abedetti@cumbrescaracas.edu.ve",
                    UserName = "abedetti",
                    NormalizedUserName = "abedetti".ToUpper(),
                    NormalizedEmail = "abedetti@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Gilberto",
                    LastNames = "Bellorin",
                    Email = "gbellorin@cumbrescaracas.edu.ve",
                    UserName = "gbellorin",
                    NormalizedUserName = "gbellorin".ToUpper(),
                    NormalizedEmail = "gbellorin@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Ezeangelly",
                    LastNames = "Bellorín",
                    Email = "ebellorin@cumbrescaracas.edu.ve",
                    UserName = "ebellorin",
                    NormalizedUserName = "ebellorin".ToUpper(),
                    NormalizedEmail = "ebellorin@cumbrescaracas.edu.ve".ToUpper()
                },
                //REQUIRES REVIEW
                new ApplicationUser
                {
                    Names = "Luana",
                    LastNames = "Benavides",
                    Email = "mgallardo@cumbrescaracas.edu.ve",
                    UserName = "mgallardo",
                    NormalizedUserName = "mgallardo".ToUpper(),
                    NormalizedEmail = "mgallardo@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Lenin",
                    LastNames = "Betancourt",
                    Email = "leninbetancourt@yahoo.es",
                    UserName = "leninbetancourt",
                    NormalizedUserName = "leninbetancourt".ToUpper(),
                    NormalizedEmail = "leninbetancourt@yahoo.es".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Andrés",
                    LastNames = "Blanco",
                    Email = "ablanco@cumbrescaracas.edu.ve",
                    UserName = "ablanco",
                    NormalizedUserName = "ablanco".ToUpper(),
                    NormalizedEmail = "ablanco@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Jorge",
                    LastNames = "Blanco",
                    Email = "jblanco@cumbrescaracas.edu.ve",
                    UserName = "jblanco",
                    NormalizedUserName = "jblanco".ToUpper(),
                    NormalizedEmail = "jblanco@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Isabel",
                    LastNames = "Bolinaga",
                    Email = "isabeldevillasmil@hotmail.com",
                    UserName = "isabeldevillasmil",
                    NormalizedUserName = "isabeldevillasmil".ToUpper(),
                    NormalizedEmail = "isabeldevillasmil@hotmail.com".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Ivette",
                    LastNames = "Bolívar",
                    Email = "ibolivar@cumbrescaracas.edu.ve",
                    UserName = "ibolivar",
                    NormalizedUserName = "ibolivar".ToUpper(),
                    NormalizedEmail = "ibolivar@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Daniel",
                    LastNames = "Brando",
                    Email = "dbrando@cumbrescaracas.edu.ve",
                    UserName = "dbrando",
                    NormalizedUserName = "dbrando".ToUpper(),
                    NormalizedEmail = "dbrando@cumbrescaracas.edu.ve".ToUpper()
                }, new ApplicationUser
                {
                    Names = "Karina",
                    LastNames = "Brun",
                    Email = "kbrun@cumbrescaracas.edu.ve",
                    UserName = "kbrun",
                    NormalizedUserName = "kbrun".ToUpper(),
                    NormalizedEmail = "kbrun@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Esther",
                    LastNames = "Calvo",
                    Email = "ecalvo@cumbrescaracas.edu.ve",
                    UserName = "ecalvo",
                    NormalizedUserName = "ecalvo".ToUpper(),
                    NormalizedEmail = "ecalvo@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "María Alejandra",
                    LastNames = "Calzadilla",
                    Email = "mcalzadilla@cumbrescaracas.edu.ve",
                    UserName = "mcalzadilla",
                    NormalizedUserName = "mcalzadilla".ToUpper(),
                    NormalizedEmail = "mcalzadilla@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Carelia",
                    LastNames = "Campos",
                    Email = "ccampos@cumbrescaracas.edu.ve",
                    UserName = "ccampos",
                    NormalizedUserName = "ccampos".ToUpper(),
                    NormalizedEmail = "ccampos@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Cristina",
                    LastNames = "Cano",
                    Email = "ccano@cumbrescaracas.edu.ve",
                    UserName = "ccano",
                    NormalizedUserName = "ccano".ToUpper(),
                    NormalizedEmail = "ccano@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Marycel",
                    LastNames = "Capuz",
                    Email = "mcapuz@cumbrescaracas.edu.ve",
                    UserName = "mcapuz",
                    NormalizedUserName = "mcapuz".ToUpper(),
                    NormalizedEmail = "mcapuz@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "José",
                    LastNames = "Caraballo",
                    Email = "jcaraballo@cumbrescaracas.edu.ve",
                    UserName = "jcaraballo",
                    NormalizedUserName = "jcaraballo".ToUpper(),
                    NormalizedEmail = "jcaraballo@cumbrescaracas.edu.ve".ToUpper()
                },
                //REQUIRES REVIEW
                new ApplicationUser
                {
                    Names = "Gwen",
                    LastNames = "Cardas",
                    Email = "gcardas@cumbrescaracas.edu.ve",
                    UserName = "gcardas",
                    NormalizedUserName = "gcardas".ToUpper(),
                    NormalizedEmail = "gcardas@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Marisela",
                    LastNames = "Cardona",
                    Email = "mcardona@cumbrescaracas.edu.ve",
                    UserName = "mcardona",
                    NormalizedUserName = "mcardona".ToUpper(),
                    NormalizedEmail = "mcardona@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Gabriela",
                    LastNames = "Carvajal",
                    Email = "gcarvajal@cumbrescaracas.edu.ve",
                    UserName = "gcarvajal",
                    NormalizedUserName = "gcarvajal".ToUpper(),
                    NormalizedEmail = "gcarvajal@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Liliana",
                    LastNames = "Casique",
                    Email = "lcasique@cumbrescaracas.edu.ve",
                    UserName = "lcasique",
                    NormalizedUserName = "lcasique".ToUpper(),
                    NormalizedEmail = "lcasique@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Mariela",
                    LastNames = "Castro",
                    Email = "mcastro@cumbrescaracas.edu.ve",
                    UserName = "mcastro",
                    NormalizedUserName = "mcastro".ToUpper(),
                    NormalizedEmail = "mcastro@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Claudia",
                    LastNames = "Chacón",
                    Email = "cchacon@cumbrescaracas.edu.ve",
                    UserName = "cchacon",
                    NormalizedUserName = "cchacon".ToUpper(),
                    NormalizedEmail = "cchacon@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Christian",
                    LastNames = "Chirinos",
                    Email = "cchirinos@cumbrescaracas.edu.ve",
                    UserName = "cchirinos",
                    NormalizedUserName = "cchirinos".ToUpper(),
                    NormalizedEmail = "cchirinos@cumbrescaracas.edu.ve".ToUpper()
                },
                //REQUIRES REVIEW
                new ApplicationUser
                {
                    Names = "Luis",
                    LastNames = "Chumbi",
                    Email = "cpadron@cumbrescaracas.edu.ve",
                    UserName = "cpadron",
                    NormalizedUserName = "cpadron".ToUpper(),
                    NormalizedEmail = "cpadron@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Andrea",
                    LastNames = "Corton",
                    Email = "acorton@cumbrescaracas.edu.ve",
                    UserName = "acorton",
                    NormalizedUserName = "acorton".ToUpper(),
                    NormalizedEmail = "acorton@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Patricia",
                    LastNames = "Daumy",
                    Email = "pdaumy@losarcos.edu.ve",
                    UserName = "pdaumy",
                    NormalizedUserName = "pdaumy".ToUpper(),
                    NormalizedEmail = "pdaumy@losarcos.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Rebeca",
                    LastNames = "Dávila",
                    Email = "rpan@cumbrescaracas.edu.ve",
                    UserName = "rpan",
                    NormalizedUserName = "rpan".ToUpper(),
                    NormalizedEmail = "rpan@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Cristina",
                    LastNames = "De Armas",
                    Email = "cdearmas@cumbrescaracas.edu.ve",
                    UserName = "cdearmas",
                    NormalizedUserName = "cdearmas".ToUpper(),
                    NormalizedEmail = "cdearmas@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Isabel",
                    LastNames = "De Gabaldon",
                    Email = "igabaldon@cumbrescaracas.edu.ve",
                    UserName = "igabaldon",
                    NormalizedUserName = "igabaldon".ToUpper(),
                    NormalizedEmail = "igabaldon@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Leiza",
                    LastNames = "Delgado",
                    Email = "ldelgado@cumbrescaracas.edu.ve",
                    UserName = "ldelgado",
                    NormalizedUserName = "ldelgado".ToUpper(),
                    NormalizedEmail = "ldelgado@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Maria Fernanda",
                    LastNames = "Diaz",
                    Email = "mdiaz@cumbrescaracas.edu.ve",
                    UserName = "mdiaz",
                    NormalizedUserName = "mdiaz".ToUpper(),
                    NormalizedEmail = "mdiaz@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Carolina",
                    LastNames = "Díaz",
                    Email = "cadiaz@arcol.org",
                    UserName = "cadiaz",
                    NormalizedUserName = "cadiaz".ToUpper(),
                    NormalizedEmail = "cadiaz@arcol.org".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Guadalupe",
                    LastNames = "Díaz",
                    Email = "gadiaz@cumbrescaracas.edu.ve",
                    UserName = "gadiaz",
                    NormalizedUserName = "gadiaz".ToUpper(),
                    NormalizedEmail = "gadiaz@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Marianela",
                    LastNames = "Djekki",
                    Email = "mdjekki@cumbrescaracas.edu.ve",
                    UserName = "mdjekki",
                    NormalizedUserName = "mdjekki".ToUpper(),
                    NormalizedEmail = "mdjekki@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Rosa",
                    LastNames = "Dos Reis",
                    Email = "rdosreis@cumbrescaracas.edu.ve",
                    UserName = "rdosreis",
                    NormalizedUserName = "rdosreis".ToUpper(),
                    NormalizedEmail = "rdosreis@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Lilibeth",
                    LastNames = "Duque",
                    Email = "lduquem@cumbrescaracas.edu.ve",
                    UserName = "lduquem",
                    NormalizedUserName = "lduquem".ToUpper(),
                    NormalizedEmail = "lduquem@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Jeniffer",
                    LastNames = "Duran",
                    Email = "jduran@cumbrescaracas.edu.ve",
                    UserName = "jduran",
                    NormalizedUserName = "jduran".ToUpper(),
                    NormalizedEmail = "jduran@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Ricky",
                    LastNames = "Escobar",
                    Email = "rescobar@arcol.org",
                    UserName = "rescobar",
                    NormalizedUserName = "rescobar".ToUpper(),
                    NormalizedEmail = "rescobar@arcol.org".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "María Graciela",
                    LastNames = "Estévez",
                    Email = "mestevez@cumbrescaracas.edu.ve",
                    UserName = "mestevez",
                    NormalizedUserName = "mestevez".ToUpper(),
                    NormalizedEmail = "mestevez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Alfonso Eloy",
                    LastNames = "Feola Carrasquel",
                    Email = "afeola@cumbrescaracas.edu.ve",
                    UserName = "afeola",
                    NormalizedUserName = "afeola".ToUpper(),
                    NormalizedEmail = "afeola@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Paula",
                    LastNames = "Fernández",
                    Email = "pfernandez@cumbrescaracas.edu.ve",
                    UserName = "pfernandez",
                    NormalizedUserName = "pfernandez".ToUpper(),
                    NormalizedEmail = "pfernandez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Rosmary",
                    LastNames = "Fernández",
                    Email = "rofernandez@cumbrescaracas.edu.ve",
                    UserName = "rofernandez",
                    NormalizedUserName = "rofernandez".ToUpper(),
                    NormalizedEmail = "rofernandez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Marianella",
                    LastNames = "Fuenmayor",
                    Email = "mfuenmayor@cumbrescaracas.edu.ve",
                    UserName = "mfuenmayor",
                    NormalizedUserName = "mfuenmayor".ToUpper(),
                    NormalizedEmail = "mfuenmayor@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Solimar",
                    LastNames = "Fuenmayor",
                    Email = "sfuenmayor@cumbrescaracas.edu.ve",
                    UserName = "sfuenmayor",
                    NormalizedUserName = "sfuenmayor".ToUpper(),
                    NormalizedEmail = "sfuenmayor@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Tayling",
                    LastNames = "Galindo",
                    Email = "tayling_steffany@hotmail.com",
                    UserName = "tayling_steffany",
                    NormalizedUserName = "tayling_steffany".ToUpper(),
                    NormalizedEmail = "tayling_steffany@hotmail.com".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Raffaela",
                    LastNames = "Gallo",
                    Email = "rgallo@cumbrescaracas.edu.ve",
                    UserName = "rgallo",
                    NormalizedUserName = "rgallo".ToUpper(),
                    NormalizedEmail = "rgallo@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Adrian",
                    LastNames = "Galviz",
                    Email = "agalviz@cumbrescaracas.edu.ve",
                    UserName = "agalviz",
                    NormalizedUserName = "agalviz".ToUpper(),
                    NormalizedEmail = "agalviz@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Alvaro",
                    LastNames = "García",
                    Email = "amgarcia@legionaries.org",
                    UserName = "amgarcia",
                    NormalizedUserName = "amgarcia".ToUpper(),
                    NormalizedEmail = "amgarcia@legionaries.org".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Jesús",
                    LastNames = "García",
                    Email = "jgarcia@cumbrescaracas.edu.ve",
                    UserName = "jgarcia",
                    NormalizedUserName = "jgarcia".ToUpper(),
                    NormalizedEmail = "jgarcia@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Teresita",
                    LastNames = "García",
                    Email = "tgarcia@cumbrescaracas.edu.ve",
                    UserName = "tgarcia",
                    NormalizedUserName = "tgarcia".ToUpper(),
                    NormalizedEmail = "tgarcia@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Jesús Enrique",
                    LastNames = "Gil",
                    Email = "jgil@cumbrescaracas.edu.ve",
                    UserName = "jgil",
                    NormalizedUserName = "jgil".ToUpper(),
                    NormalizedEmail = "jgil@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Donatina",
                    LastNames = "Giuliani",
                    Email = "dgiuliani@cumbrescaracas.edu.ve",
                    UserName = "dgiuliani",
                    NormalizedUserName = "dgiuliani".ToUpper(),
                    NormalizedEmail = "dgiuliani@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Carlos",
                    LastNames = "Gomez",
                    Email = "cgomez@cumbrescaracas.edu.ve",
                    UserName = "cgomez",
                    NormalizedUserName = "cgomez".ToUpper(),
                    NormalizedEmail = "cgomez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Mariana",
                    LastNames = "González",
                    Email = "mgonzalez@cumbrescaracas.edu.ve",
                    UserName = "mgonzalez",
                    NormalizedUserName = "mgonzalez".ToUpper(),
                    NormalizedEmail = "mgonzalez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Rossana",
                    LastNames = "González",
                    Email = "rvgonzalez@cumbrescaracas.edu.ve",
                    UserName = "rvgonzalez",
                    NormalizedUserName = "rvgonzalez".ToUpper(),
                    NormalizedEmail = "rvgonzalez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Arminda",
                    LastNames = "Guerra",
                    Email = "arguerra@cumbrescaracas.edu.ve",
                    UserName = "arguerra",
                    NormalizedUserName = "arguerra".ToUpper(),
                    NormalizedEmail = "arguerra@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Jessica",
                    LastNames = "Guillén",
                    Email = "jguillen@cumbrescaracas.edu.ve",
                    UserName = "jguillen",
                    NormalizedUserName = "jguillen".ToUpper(),
                    NormalizedEmail = "jguillen@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "María Fernanda",
                    LastNames = "Guillén",
                    Email = "mguillen@cumbrescaracas.edu.ve",
                    UserName = "mguillen",
                    NormalizedUserName = "mguillen".ToUpper(),
                    NormalizedEmail = "mguillen@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "José Manuel",
                    LastNames = "Gutierrez",
                    Email = "jmgutierrez@cumbrescracas.edu.ve",
                    UserName = "jmgutierrez",
                    NormalizedUserName = "jmgutierrez".ToUpper(),
                    NormalizedEmail = "jmgutierrez@cumbrescracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Leonardo",
                    LastNames = "Gutiérrez",
                    Email = "legutierrez@cumbrescaracas.edu.ve",
                    UserName = "legutierrez",
                    NormalizedUserName = "legutierrez".ToUpper(),
                    NormalizedEmail = "legutierrez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Selene",
                    LastNames = "Harrisson",
                    Email = "sharrisson@cumbrescaracas.edu.ve",
                    UserName = "sharrisson",
                    NormalizedUserName = "sharrisson".ToUpper(),
                    NormalizedEmail = "sharrisson@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Andrés",
                    LastNames = "Henríquez",
                    Email = "ahenriquez@cumbrescaracas.edu.ve",
                    UserName = "ahenriquez",
                    NormalizedUserName = "ahenriquez".ToUpper(),
                    NormalizedEmail = "ahenriquez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Carlos",
                    LastNames = "Henríquez",
                    Email = "chenriquez@cumbrescaracas.edu.ve",
                    UserName = "chenriquez",
                    NormalizedUserName = "chenriquez".ToUpper(),
                    NormalizedEmail = "chenriquez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Monica",
                    LastNames = "Hernandez",
                    Email = "mhernandez@cumbrescaracas.edu.ve",
                    UserName = "mhernandez",
                    NormalizedUserName = "mhernandez".ToUpper(),
                    NormalizedEmail = "mhernandez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "María Alejandra",
                    LastNames = "Herrera Bello",
                    Email = "maherrera@cumbrescaracas.edu.ve",
                    UserName = "maherrera",
                    NormalizedUserName = "maherrera".ToUpper(),
                    NormalizedEmail = "maherrera@cumbrescaracas.edu.ve".ToUpper()
                },
                //REQUIRES REVIEW
                new ApplicationUser
                {
                    Names = "Marianna",
                    LastNames = "Itriago",
                    Email = "mitriago@cumbrescaracas.edu.ve",
                    UserName = "mitriago",
                    NormalizedUserName = "mitriago".ToUpper(),
                    NormalizedEmail = "mitriago@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Beatriz",
                    LastNames = "Losada",
                    Email = "blosada@cumbrescaracas.edu.ve",
                    UserName = "blosada",
                    NormalizedUserName = "blosada".ToUpper(),
                    NormalizedEmail = "blosada@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Adriana",
                    LastNames = "Lovera",
                    Email = "alovera@cumbrescarcas.edu.ve",
                    UserName = "alovera",
                    NormalizedUserName = "alovera".ToUpper(),
                    NormalizedEmail = "alovera@cumbrescarcas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Ivette",
                    LastNames = "Luca",
                    Email = "iluca@cumbrescaracas.edu.ve",
                    UserName = "iluca",
                    NormalizedUserName = "iluca".ToUpper(),
                    NormalizedEmail = "iluca@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Deyvi",
                    LastNames = "Lucero",
                    Email = "dlucero@cumbrescaracas.edu.ve",
                    UserName = "dlucero",
                    NormalizedUserName = "dlucero".ToUpper(),
                    NormalizedEmail = "dlucero@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Ismael José",
                    LastNames = "Lugo Caravallo",
                    Email = "ilugo@cumbrescaracas.edu.ve",
                    UserName = "ilugo",
                    NormalizedUserName = "ilugo".ToUpper(),
                    NormalizedEmail = "ilugo@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Ana Teresa",
                    LastNames = "Machado",
                    Email = "ayepes@cumbrescaracas.edu.ve",
                    UserName = "ayepes",
                    NormalizedUserName = "ayepes".ToUpper(),
                    NormalizedEmail = "ayepes@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Nancy",
                    LastNames = "Magdaleno",
                    Email = "nmagdaleno@cumbrescaracas.edu.ve",
                    UserName = "nmagdaleno",
                    NormalizedUserName = "nmagdaleno".ToUpper(),
                    NormalizedEmail = "nmagdaleno@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Mario",
                    LastNames = "Manrique",
                    Email = "mariomanrique@cumbrescaracas.edu.ve",
                    UserName = "mariomanrique",
                    NormalizedUserName = "mariomanrique".ToUpper(),
                    NormalizedEmail = "mariomanrique@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Karina",
                    LastNames = "Marcano",
                    Email = "kmarcano@cumbrescaracas.edu.ve",
                    UserName = "kmarcano",
                    NormalizedUserName = "kmarcano".ToUpper(),
                    NormalizedEmail = "kmarcano@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Juliana",
                    LastNames = "Mármol",
                    Email = "jumarmol@cumbrescaracas.edu.ve",
                    UserName = "jumarmol",
                    NormalizedUserName = "jumarmol".ToUpper(),
                    NormalizedEmail = "jumarmol@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "María Esperanza",
                    LastNames = "Márquez",
                    Email = "mmarquez@cumbrescaracas.edu.ve",
                    UserName = "mmarquez",
                    NormalizedUserName = "mmarquez".ToUpper(),
                    NormalizedEmail = "mmarquez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Julio César",
                    LastNames = "Martí",
                    Email = "jmarti@legionaries.org",
                    UserName = "jmarti",
                    NormalizedUserName = "jmarti".ToUpper(),
                    NormalizedEmail = "jmarti@legionaries.org".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Diego",
                    LastNames = "Marval",
                    Email = "dmarval@cumbrescaracas.edu.ve",
                    UserName = "dmarval",
                    NormalizedUserName = "dmarval".ToUpper(),
                    NormalizedEmail = "dmarval@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Alberto",
                    LastNames = "Marzucco",
                    Email = "amarzucco@cumbrescaracas.edu.ve",
                    UserName = "amarzucco",
                    NormalizedUserName = "amarzucco".ToUpper(),
                    NormalizedEmail = "amarzucco@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "David",
                    LastNames = "Mata",
                    Email = "dmata@cumbrescaracas.edu.ve",
                    UserName = "dmata",
                    NormalizedUserName = "dmata".ToUpper(),
                    NormalizedEmail = "dmata@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "María Carolina",
                    LastNames = "Mata De Mora",
                    Email = "mmata@arcol.org",
                    UserName = "mmata",
                    NormalizedUserName = "mmata".ToUpper(),
                    NormalizedEmail = "mmata@arcol.org".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Isabel",
                    LastNames = "Maurovich",
                    Email = "imaurovich@cumbrescaracas.edu.ve",
                    UserName = "imaurovich",
                    NormalizedUserName = "imaurovich".ToUpper(),
                    NormalizedEmail = "imaurovich@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Iliana",
                    LastNames = "Mejias",
                    Email = "imejias@cumbrescaracas.edu.ve",
                    UserName = "imejias",
                    NormalizedUserName = "imejias".ToUpper(),
                    NormalizedEmail = "imejias@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Luisa",
                    LastNames = "Mesa",
                    Email = "lmesa@cumbrescaracas.edu.ve",
                    UserName = "lmesa",
                    NormalizedUserName = "lmesa".ToUpper(),
                    NormalizedEmail = "lmesa@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Mariana",
                    LastNames = "Michelena",
                    Email = "mmichelena@cumbrescaracas.edu.ve",
                    UserName = "mmichelena",
                    NormalizedUserName = "mmichelena".ToUpper(),
                    NormalizedEmail = "mmichelena@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Juan Izquierdo",
                    LastNames = "Montilla",
                    Email = "jmontilla@cumbrescaracas.edu.ve",
                    UserName = "jmontilla",
                    NormalizedUserName = "jmontilla".ToUpper(),
                    NormalizedEmail = "jmontilla@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Desiree",
                    LastNames = "Moreau",
                    Email = "dmoreau@cumbrescaracas.edu.ve",
                    UserName = "dmoreau",
                    NormalizedUserName = "dmoreau".ToUpper(),
                    NormalizedEmail = "dmoreau@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Yenny",
                    LastNames = "Moreira",
                    Email = "ymoreira@cumbrescaracas.edu.ve",
                    UserName = "ymoreira",
                    NormalizedUserName = "ymoreira".ToUpper(),
                    NormalizedEmail = "ymoreira@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Katherine",
                    LastNames = "Moreno",
                    Email = "kmoreno@cumbrescaracas.edu.ve",
                    UserName = "kmoreno",
                    NormalizedUserName = "kmoreno".ToUpper(),
                    NormalizedEmail = "kmoreno@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "María Alejandra",
                    LastNames = "Nakhal Akel",
                    Email = "mnakhal@cumbrescaracas.edu.ve",
                    UserName = "mnakhal",
                    NormalizedUserName = "mnakhal".ToUpper(),
                    NormalizedEmail = "mnakhal@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Dayhan",
                    LastNames = "Nava",
                    Email = "dnava@cumbrescaracas.edu.ve",
                    UserName = "dnava",
                    NormalizedUserName = "dnava".ToUpper(),
                    NormalizedEmail = "dnava@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Carlos",
                    LastNames = "Noguera",
                    Email = "cnoguera@cumbrescaracas.edu.ve",
                    UserName = "cnoguera",
                    NormalizedUserName = "cnoguera".ToUpper(),
                    NormalizedEmail = "cnoguera@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Yndhira",
                    LastNames = "Oropeza",
                    Email = "yoropeza@cumbrescaracas.edu.ve",
                    UserName = "yoropeza",
                    NormalizedUserName = "yoropeza".ToUpper(),
                    NormalizedEmail = "yoropeza@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Gabriela",
                    LastNames = "Ortega",
                    Email = "gaortega@cumbrescaracas.edu.ve",
                    UserName = "gaortega",
                    NormalizedUserName = "gaortega".ToUpper(),
                    NormalizedEmail = "gaortega@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Andreulys",
                    LastNames = "Ortuño",
                    Email = "aortuno@cumbrescaracas.edu.ve",
                    UserName = "aortuno",
                    NormalizedUserName = "aortuno".ToUpper(),
                    NormalizedEmail = "aortuno@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Pedro",
                    LastNames = "Paris",
                    Email = "pparis@cumbrescaracas.edu.ve",
                    UserName = "pparis",
                    NormalizedUserName = "pparis".ToUpper(),
                    NormalizedEmail = "pparis@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "María Virginia",
                    LastNames = "Parra",
                    Email = "mparra@cumbrescaracas.edu.ve",
                    UserName = "mparra",
                    NormalizedUserName = "mparra".ToUpper(),
                    NormalizedEmail = "mparra@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "María Antonieta",
                    LastNames = "Peñaranda",
                    Email = "mpenaranda@cumbrescaracas.edu.ve",
                    UserName = "mpenaranda",
                    NormalizedUserName = "mpenaranda".ToUpper(),
                    NormalizedEmail = "mpenaranda@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Beatriz",
                    LastNames = "Perez",
                    Email = "bperez@cumbrescaracas.edu.ve",
                    UserName = "bperez",
                    NormalizedUserName = "bperez".ToUpper(),
                    NormalizedEmail = "bperez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Mayela",
                    LastNames = "Pérez",
                    Email = "mperezr@cumbrescaracas.edu.ve",
                    UserName = "mperezr",
                    NormalizedUserName = "mperezr".ToUpper(),
                    NormalizedEmail = "mperezr@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Leonardo",
                    LastNames = "Perez Castilla",
                    Email = "lperezcastilla@legionaries.org",
                    UserName = "lperezcastilla",
                    NormalizedUserName = "lperezcastilla".ToUpper(),
                    NormalizedEmail = "lperezcastilla@legionaries.org".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Daniela Alejandra",
                    LastNames = "Perrucci Meló",
                    Email = "dperrucci@cumbrescaracas.edu.ve",
                    UserName = "dperrucci",
                    NormalizedUserName = "dperrucci".ToUpper(),
                    NormalizedEmail = "dperrucci@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Adriana",
                    LastNames = "Piñero",
                    Email = "apinero@cumbrescaracas.edu.ve",
                    UserName = "apinero",
                    NormalizedUserName = "apinero".ToUpper(),
                    NormalizedEmail = "apinero@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Rafael",
                    LastNames = "Punceles",
                    Email = "rpunceles@cumbrescaracas.edu.ve",
                    UserName = "rpunceles",
                    NormalizedUserName = "rpunceles".ToUpper(),
                    NormalizedEmail = "rpunceles@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Carla",
                    LastNames = "Quintana",
                    Email = "cquintana@cumbrescaracas.edu.ve",
                    UserName = "cquintana",
                    NormalizedUserName = "cquintana".ToUpper(),
                    NormalizedEmail = "cquintana@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "María",
                    LastNames = "Ramos",
                    Email = "mramos@cumbrescaracas.edu.ve",
                    UserName = "mramos",
                    NormalizedUserName = "mramos".ToUpper(),
                    NormalizedEmail = "mramos@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Gabriela",
                    LastNames = "Rando",
                    Email = "grando@cumbrescaracas.edu.ve",
                    UserName = "grando",
                    NormalizedUserName = "grando".ToUpper(),
                    NormalizedEmail = "grando@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Ignacio",
                    LastNames = "Rangel",
                    Email = "irangel@cumbrescaracas.edu.ve",
                    UserName = "irangel",
                    NormalizedUserName = "irangel".ToUpper(),
                    NormalizedEmail = "irangel@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Marco Aurelio",
                    LastNames = "Rangel",
                    Email = "mrangel@cumbrescaracas.edu.ve",
                    UserName = "mrangel",
                    NormalizedUserName = "mrangel".ToUpper(),
                    NormalizedEmail = "mrangel@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Mauricio",
                    LastNames = "Recchiuti",
                    Email = "mrecchiuti@cumbrescaracas.edu.ve",
                    UserName = "mrecchiuti",
                    NormalizedUserName = "mrecchiuti".ToUpper(),
                    NormalizedEmail = "mrecchiuti@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Angeli",
                    LastNames = "Rene",
                    Email = "rangeli@cumbrescaracas.edu.ve",
                    UserName = "rangeli",
                    NormalizedUserName = "rangeli".ToUpper(),
                    NormalizedEmail = "rangeli@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Jose",
                    LastNames = "Rivas",
                    Email = "joserivas@cumbrescaracas.edu.ve",
                    UserName = "joserivas",
                    NormalizedUserName = "joserivas".ToUpper(),
                    NormalizedEmail = "joserivas@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Julieta",
                    LastNames = "Rivas",
                    Email = "julieta.elena.rivas@gmail.com",
                    UserName = "julieta.elena.rivas",
                    NormalizedUserName = "julieta.elena.rivas".ToUpper(),
                    NormalizedEmail = "julieta.elena.rivas@gmail.com".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Mariana",
                    LastNames = "Rivas",
                    Email = "mrivas@cumbrescaracas.edu.ve",
                    UserName = "mrivas",
                    NormalizedUserName = "mrivas".ToUpper(),
                    NormalizedEmail = "mrivas@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Marisela",
                    LastNames = "Rocha",
                    Email = "mariselayjorge@hotmail.com",
                    UserName = "mariselayjorge",
                    NormalizedUserName = "mariselayjorge".ToUpper(),
                    NormalizedEmail = "mariselayjorge@hotmail.com".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Guida",
                    LastNames = "Rodriguez",
                    Email = "grodriguez@cumbrescaracas.edu.ve",
                    UserName = "grodriguez",
                    NormalizedUserName = "grodriguez".ToUpper(),
                    NormalizedEmail = "grodriguez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Luis Antonio",
                    LastNames = "Rodriguez",
                    Email = "lrodriguez@cumbrescaracas.edu.ve",
                    UserName = "lrodriguez",
                    NormalizedUserName = "lrodriguez".ToUpper(),
                    NormalizedEmail = "lrodriguez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "María Corina",
                    LastNames = "Rodríguez",
                    Email = "mrodriguez@cumbrescaracas.edu.ve",
                    UserName = "mrodriguez",
                    NormalizedUserName = "mrodriguez".ToUpper(),
                    NormalizedEmail = "mrodriguez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Ana",
                    LastNames = "Rodríguez",
                    Email = "arodriguez@cumbrescaracas.edu.ve",
                    UserName = "arodriguez",
                    NormalizedUserName = "arodriguez".ToUpper(),
                    NormalizedEmail = "arodriguez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Daniella",
                    LastNames = "Rodríguez",
                    Email = "drodriguez@cumbrescaracas.edu.ve",
                    UserName = "drodriguez",
                    NormalizedUserName = "drodriguez".ToUpper(),
                    NormalizedEmail = "drodriguez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "José Andrés",
                    LastNames = "Rodríguez",
                    Email = "jorodriguez@cumbrescaracas.edu.ve",
                    UserName = "jorodriguez",
                    NormalizedUserName = "jorodriguez".ToUpper(),
                    NormalizedEmail = "jorodriguez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Mauricio",
                    LastNames = "Rodríguez",
                    Email = "maurodriguez@cumbrescaracas.edu.ve",
                    UserName = "maurodriguez",
                    NormalizedUserName = "maurodriguez".ToUpper(),
                    NormalizedEmail = "maurodriguez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Zamanta",
                    LastNames = "Rodríguez",
                    Email = "zrodriguez@cumbrescaracas.edu.ve",
                    UserName = "zrodriguez",
                    NormalizedUserName = "zrodriguez".ToUpper(),
                    NormalizedEmail = "zrodriguez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Andy",
                    LastNames = "Rojas",
                    Email = "arojas@arcol.org",
                    UserName = "arojas",
                    NormalizedUserName = "arojas".ToUpper(),
                    NormalizedEmail = "arojas@arcol.org".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Dayana",
                    LastNames = "Rondon",
                    Email = "drondon@cumbrescaracas.edu.ve",
                    UserName = "drondon",
                    NormalizedUserName = "drondon".ToUpper(),
                    NormalizedEmail = "drondon@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Gabriel",
                    LastNames = "Salas",
                    Email = "gsalas@cumbrescaracas.edu.ve",
                    UserName = "gsalas",
                    NormalizedUserName = "gsalas".ToUpper(),
                    NormalizedEmail = "gsalas@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Gabriela",
                    LastNames = "Salas",
                    Email = "clopez@cumbrescaracas.edu.ve",
                    UserName = "clopez",
                    NormalizedUserName = "clopez".ToUpper(),
                    NormalizedEmail = "clopez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Rosario",
                    LastNames = "Sánchez",
                    Email = "rsanchez@cumbrescaracas.edu.ve",
                    UserName = "rsanchez",
                    NormalizedUserName = "rsanchez".ToUpper(),
                    NormalizedEmail = "rsanchez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Yajaira",
                    LastNames = "Santaella",
                    Email = "ysantaella@cumbrescaracas.edu.ve",
                    UserName = "ysantaella",
                    NormalizedUserName = "ysantaella".ToUpper(),
                    NormalizedEmail = "ysantaella@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Ramon",
                    LastNames = "Sirit",
                    Email = "rsirit@cumbrescaracas.edu.ve",
                    UserName = "rsirit",
                    NormalizedUserName = "rsirit".ToUpper(),
                    NormalizedEmail = "rsirit@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Daniel",
                    LastNames = "Sossa",
                    Email = "dsossa@legionaries.org",
                    UserName = "dsossa",
                    NormalizedUserName = "dsossa".ToUpper(),
                    NormalizedEmail = "dsossa@legionaries.org".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Morela",
                    LastNames = "Sous",
                    Email = "msous@cumbrescaracas.edu.ve",
                    UserName = "msous",
                    NormalizedUserName = "msous".ToUpper(),
                    NormalizedEmail = "msous@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Joaquin",
                    LastNames = "Suanno",
                    Email = "ninosuanno@cumbrescaracas.edu.ve",
                    UserName = "ninosuanno",
                    NormalizedUserName = "ninosuanno".ToUpper(),
                    NormalizedEmail = "ninosuanno@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "César",
                    LastNames = "Suárez",
                    Email = "csuarez@cumbrescaracas.edu.ve",
                    UserName = "csuarez",
                    NormalizedUserName = "csuarez".ToUpper(),
                    NormalizedEmail = "csuarez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Lisette",
                    LastNames = "Tavares Goncalves",
                    Email = "ltavares@cumbrescaracas.edu.ve",
                    UserName = "ltavares",
                    NormalizedUserName = "ltavares".ToUpper(),
                    NormalizedEmail = "ltavares@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Wilmer",
                    LastNames = "Terán",
                    Email = "wteran@cumbrescaracas.edu.ve",
                    UserName = "wteran",
                    NormalizedUserName = "wteran".ToUpper(),
                    NormalizedEmail = "wteran@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "José Carlos",
                    LastNames = "Thimotheo",
                    Email = "jthimotheo@cumbrescaracas.edu.ve",
                    UserName = "jthimotheo",
                    NormalizedUserName = "jthimotheo".ToUpper(),
                    NormalizedEmail = "jthimotheo@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Bruno",
                    LastNames = "Togni",
                    Email = "btogni@cumbrescaracas.edu.ve",
                    UserName = "btogni",
                    NormalizedUserName = "btogni".ToUpper(),
                    NormalizedEmail = "btogni@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Jorge",
                    LastNames = "Toro",
                    Email = "jtoro@cumbrescaracas.edu.ve",
                    UserName = "jtoro",
                    NormalizedUserName = "jtoro".ToUpper(),
                    NormalizedEmail = "jtoro@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Maria Gabriela",
                    LastNames = "Tortosa",
                    Email = "mtortosa@cumbrescaracas.edu.ve",
                    UserName = "mtortosa",
                    NormalizedUserName = "mtortosa".ToUpper(),
                    NormalizedEmail = "mtortosa@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Beatriz",
                    LastNames = "Trias",
                    Email = "btrias@cumbrescaracas.edu.ve",
                    UserName = "btrias",
                    NormalizedUserName = "btrias".ToUpper(),
                    NormalizedEmail = "btrias@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "María Elena",
                    LastNames = "Trujillo",
                    Email = "mtrujillo@cumbrescaracas.edu.ve",
                    UserName = "mtrujillo",
                    NormalizedUserName = "mtrujillo".ToUpper(),
                    NormalizedEmail = "mtrujillo@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Carlos",
                    LastNames = "Urdaneta",
                    Email = "carlosurdaneta@cumbrescaracas.edu.ve",
                    UserName = "carlosurdaneta",
                    NormalizedUserName = "carlosurdaneta".ToUpper(),
                    NormalizedEmail = "carlosurdaneta@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Leonidas",
                    LastNames = "Urueta",
                    Email = "lurueta@cumbrescaracas.edu.ve",
                    UserName = "lurueta",
                    NormalizedUserName = "lurueta".ToUpper(),
                    NormalizedEmail = "lurueta@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Andrea",
                    LastNames = "Valderrama",
                    Email = "avalderrama@cumbrescaracas.edu.ve",
                    UserName = "avalderrama",
                    NormalizedUserName = "avalderrama".ToUpper(),
                    NormalizedEmail = "avalderrama@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Melanie",
                    LastNames = "Valladares",
                    Email = "melavalladares@gmail.com",
                    UserName = "melavalladares",
                    NormalizedUserName = "melavalladares".ToUpper(),
                    NormalizedEmail = "melavalladares@gmail.com".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Gabriel",
                    LastNames = "Velandia",
                    Email = "gvelandia@cumbrescaracas.edu.ve",
                    UserName = "gvelandia",
                    NormalizedUserName = "gvelandia".ToUpper(),
                    NormalizedEmail = "gvelandia@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Perla Marina",
                    LastNames = "Velásquez",
                    Email = "mvelasquez@cumbrescaracas.edu.ve",
                    UserName = "mvelasquez",
                    NormalizedUserName = "mvelasquez".ToUpper(),
                    NormalizedEmail = "mvelasquez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "María Gabriela",
                    LastNames = "Villasmil",
                    Email = "mvillasmil@cumbrescaracas.edu.ve",
                    UserName = "mvillasmil",
                    NormalizedUserName = "mvillasmil".ToUpper(),
                    NormalizedEmail = "mvillasmil@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Vanessa",
                    LastNames = "Vinck",
                    Email = "vvinck@cumbrescaracas.edu.ve",
                    UserName = "vvinck",
                    NormalizedUserName = "vvinck".ToUpper(),
                    NormalizedEmail = "vvinck@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Alejandra",
                    LastNames = "Vivas",
                    Email = "avivas@cumbrescaracas.edu.ve",
                    UserName = "avivas",
                    NormalizedUserName = "avivas".ToUpper(),
                    NormalizedEmail = "avivas@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Marisela",
                    LastNames = "Vizcarrondo",
                    Email = "mrocha@cumbrescaracas.edu.ve",
                    UserName = "mrocha",
                    NormalizedUserName = "mrocha".ToUpper(),
                    NormalizedEmail = "mrocha@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "América",
                    LastNames = "Vona",
                    Email = "adipentima@cumbrescaracas.edu.ve",
                    UserName = "adipentima",
                    NormalizedUserName = "adipentima".ToUpper(),
                    NormalizedEmail = "adipentima@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Miguel Angel",
                    LastNames = "Yanez",
                    Email = "myanez@cumbrescaracas.edu.ve",
                    UserName = "myanez",
                    NormalizedUserName = "myanez".ToUpper(),
                    NormalizedEmail = "myanez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Simón",
                    LastNames = "Yanez",
                    Email = "syanez@cumbrescaracas.edu.ve",
                    UserName = "syanez",
                    NormalizedUserName = "syanez".ToUpper(),
                    NormalizedEmail = "syanez@cumbrescaracas.edu.ve".ToUpper()
                },
                new ApplicationUser
                {
                    Names = "Alexis",
                    LastNames = "Zambrano",
                    Email = "azambrano@cumbrescaracas.edu.ve",
                    UserName = "azambrano",
                    NormalizedUserName = "azambrano".ToUpper(),
                    NormalizedEmail = "azambrano@cumbrescaracas.edu.ve".ToUpper()
                }
            );

        }
    }
}
