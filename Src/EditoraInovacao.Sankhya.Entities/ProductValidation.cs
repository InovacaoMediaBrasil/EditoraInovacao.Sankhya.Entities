using System.ComponentModel;
using System.Text.RegularExpressions;

namespace EditoraInovacao.Sankhya.Entities;

public static class ProductValidation
{
    /// <summary>
    /// The product code and name pattern
    /// </summary>
    public static readonly Regex ProductCodeAndNamePattern = new(
        @"""(?<code>\d+)\s-\s(?<name>.+)""",
        RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled
    );

    /// <summary>
    /// The invalid description pattern
    /// </summary>
    public static readonly Regex InvalidDescriptionPattern = new(
        @"^(\r\n)?(DESCRIÇÃO\:?(\r\n){0,2})?",
        RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled
    );

    /// <summary>
    /// The Vimeo video pattern
    /// </summary>
    public static readonly Regex VimeoVideoPattern = new(
        @"^(?:https?:\/\/)?(?:(?:www|player).)?vimeo.com(?:\/video)?\/(?<id>\d+)(?:\?.*)?",
        RegexOptions.IgnoreCase
            | RegexOptions.CultureInvariant
            | RegexOptions.Compiled
            | RegexOptions.Multiline
    );

    /// <summary>
    /// The online course attachment pattern
    /// </summary>
    public static readonly Regex OnlineCourseAttachmentPattern = new(
        @"^(?:(?:http://)?(?:www.)?vitrinedoartesanatodigital.com.br/)Images/Attachments/(?<fileName>.+?)\.pdf",
        RegexOptions.IgnoreCase
            | RegexOptions.CultureInvariant
            | RegexOptions.Compiled
            | RegexOptions.Multiline
    );

    /// <summary>
    /// The invalid NCM pattern
    /// </summary>
    public static readonly Regex InvalidNcmPattern = new(
        @"Código NCM inválido na nota (?<nota>[0-9]+), produto (?<produto>[0-9]+):(\s)?(?<ncm>.+?)?",
        RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled
    );

    /// <summary>
    /// The invalid origin pattern
    /// </summary>
    public static readonly Regex InvalidOriginPattern = new(
        @"The value '(\[\d\])' of element 'orig' is not valid.",
        RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled
    );

    /// <summary>
    /// The invalid cfop pattern
    /// </summary>
    public static readonly Regex InvalidCfopPattern = new(
        @"The value '(\d+)' of element 'CFOP' is not valid.",
        RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled
    );

    /// <summary>
    /// The words upper case
    /// </summary>
    [Localizable(false)]
    public static readonly string[] WordsUpperCase = { "DVD", "PET", "E.V.A", "EVA", "3D" };

    /// <summary>
    /// The words lower case
    /// </summary>
    [Localizable(false)]
    public static readonly string[] WordsLowerCase =
    {
        "e",
        "a",
        "a",
        "as",
        "o",
        "os",
        "ao",
        "aos",
        "à",
        "às",
        "do",
        "dos",
        "da",
        "das",
        "de",
        "pra",
        "para",
        "com",
        "sem",
        "sob",
        "em",
        "até",
    };

    /// <summary>
    /// The new line pattern
    /// </summary>
    [Localizable(false)]
    public static readonly string[] NewLinePattern =
    {
        "\n",
        "\r\n",
        "<br />",
        "<br>",
        "<br/>",
        "${nl}",
    };
}
