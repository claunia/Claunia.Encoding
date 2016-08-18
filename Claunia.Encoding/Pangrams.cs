//
// Pangrams.cs
//
// Author:
//       Natalia Portillo <claunia@claunia.com>
//
// Copyright (c) 2016 © Claunia.com
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
namespace Claunia.Encoding
{
    public static class Pangrams
    {
        public const string Arabic = "صِف خَلقَ خَودِ كَمِثلِ الشَمسِ إِذ بَزَغَت — يَحظى الضَجيعُ بِها نَجلاءَ مِعطارِ";
        public const string Azeri = "Zəfər, jaketini də papağını da götür, bu axşam hava çox soyuq olacaq.";
        public const string Basque = "Vaudeville itxurako filmean, yogi ñaño bat jipoitzen dute Quebec-en, whiski truk";
        public const string Breton = "Yec’hed mat Jakez ! Skarzhit ar gwerennoù-mañ, kavet e vo gwin betek fin ho puhez.";
        public const string Bulgarian = "Хълцащ змей плюе шофьор стигнал чуждия бивак.";
        public const string Catalan = "«Dóna amor que seràs feliç!». Això, il·lús company geniüt, ja és un lluït rètol blavís d’onze kWh.";
        public const string ChineseTraditional = "視野無限廣，窗外有藍天";
        public const string ChineseSimplified = "Innovation in China 中国智造，慧及全球";
        public const string Croatian = "Gojazni đačić s biciklom drži hmelj i finu vatu u džepu nošnje.";
        public const string Czech = "Nechť již hříšné saxofony ďáblů rozezvučí síň úděsnými tóny waltzu, tanga a quickstepu.";
        public const string Danish = "Quizdeltagerne spiste jordbær med fløde, mens cirkusklovnen Walther spillede på xylofon.";
        public const string Dutch = "Pa’s wijze lynx bezag vroom het fikse aquaduct.";
        public const string English = "The quick brown fox jumps over the lazy dog.";
        public const string Esperanto = "Eble ĉiu kvazaŭ-deca fuŝĥoraĵo ĝojigos homtipon.";
        public const string Estonian = "Põdur Zagrebi tšellomängija-följetonist Ciqo külmetas kehvas garaažis.";
        public const string Finnish = "Fahrenheit ja Celsius yrjösivät Åsan backgammon-peliin, Volkswagenissa, daiquirin ja ZX81:n yhteisvaikutuksesta.";
        public const string French = "Le cœur déçu mais l'âme plutôt naïve, Louÿs rêva de crapaüter en canoë au delà des îles, près du mälströn où brûlent les novæ.";
        public const string Galician = "Necesitamos unha tipografía chuliña de cor kiwi, que lle zorregue unha labazada visual á xente.";
        public const string German = "Falsches Üben von Xylophonmusik quält jeden größeren Zwerg.";
        public const string Greek = "Ταχίστη αλώπηξ βαφής ψημένη γη, δρασκελίζει υπέρ νωθρού κυνός Takhístè alôpèx vaphês psèménè gè, draskelízei ypér nòthroý kynós.";
        public const string Hebrew = "לכן חכו לי נאם יהוה ליום קומי לעד, כי משפטי לאסף גוים לקבצי ממלכות, לשפך עליהם זעמי כל חרון אפי, כי באש קנאתי תאכל כל הארץ";
        public const string Hungarian = "Jó foxim és don Quijote húszwattos lámpánál ülve egy pár bűvös cipőt készít.";
        public const string Icelandic = "Kæmi ný öxi hér, ykist þjófum nú bæði víl og ádrepa.";
        public const string Irish = "Ċuaiġ bé ṁórṡáċ le dlúṫspád fíorḟinn trí hata mo ḋea-ṗorcáin ḃig";
        public const string Japanese = "いろはにほへと ちりぬるを わかよたれそ つねならむ うゐのおくやま けふこえて あさきゆめみし ゑひもせす（ん）";
        public const string JapaneseKanji = "色は匂へど 散りぬるを 我が世誰ぞ 常ならむ 有為の奥山 今日越えて 浅き夢見じ 酔ひもせず（ん）";
        public const string Korean = "키스의 고유조건은 입술끼리 만나야 하고 특별한 기술은 필요치 않다";
        public const string Latvian = "Četri psihi faķīri vēlu vakarā zāģēja guļbūvei durvis, fonā šņācot mežam.";
        public const string Lithuanian = "Įlinkdama fechtuotojo špaga sublykčiojusi pragręžė apvalų arbūzą";
        public const string Macedonian = "Ѕидарски пејзаж: шугав билмез со чудење џвака ќофте и кељ на туѓ цех.";
        public const string Norwegian = "Jeg begynte å fortære en sandwich mens jeg kjørte taxi på vei til quiz";
        public const string Polish = "Jeżu klątw, spłódź Finom część gry hańb!";
        public const string Portuguese = "À noite, vovô Kowalsky vê o ímã cair no pé do pingüim queixoso e vovó põe açúcar no chá de tâmaras do jabuti feliz.";
        public const string Romanian = "Înjurând pițigăiat, zoofobul comandă vexat whisky și tequila.";
        public const string Russian = "Широкая электрификация южных губерний даст мощный толчок подъёму сельского хозяйства.";
        public const string Scottish = "Mus d’fhàg Cèit-Ùna ròp Ì le ob.";
        public const string Serbian = "Gojazni đačić s biciklom drži hmelj i finu vatu u džepu nošnje.";
        public const string Slovak = "Kŕdeľ šťastných ďatľov učí pri ústí Váhu mĺkveho koňa obhrýzať kôru a žrať čerstvé mäso.";
        public const string Slovenian = "Besni dirkač iz formule žuga cehu poštarjev.";
        public const string Spanish = "El veloz murciélago hindú comía feliz cardillo y kiwi. La cigüeña tocaba el saxofón detrás del palenque de paja.";
        public const string Swedish = "Flygande bäckasiner söka hwila på mjuka tuvor.";
        public const string Turkish = "Pijamalı hasta yağız şoföre çabucak güvendi.";
        public const string Welsh = "Parciais fy jac codi baw hud llawn dŵr ger tŷ Mabon.";
    }
}

