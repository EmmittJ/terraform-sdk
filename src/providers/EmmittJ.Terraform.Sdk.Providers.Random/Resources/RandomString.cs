using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Random;

/// <summary>
/// Represents a random_string Terraform resource.
/// The resource `random_string` generates a random permutation of alphanumeric characters and optionally special characters.
    /// 
    /// This resource *does* use a cryptographic random number generator.
    /// 
    /// Historically this resource&#39;s intended usage has been ambiguous as the original example used it in a password. For backwards compatibility it will continue to exist. For unique ids please use [random_id](id.html), for sensitive random values please use [random_password](password.html).
/// </summary>
public partial class RandomString(string name) : TerraformResource("random_string", name)
{
    /// <summary>
    /// Arbitrary map of values that, when changed, will trigger recreation of resource. See [the main provider documentation](../index.html) for more information.
    /// </summary>
    public TerraformMap<string>? Keepers
    {
        get => GetArgument<TerraformMap<string>>("keepers");
        set => SetArgument("keepers", value);
    }

    /// <summary>
    /// The length of the string desired. The minimum value for length is 1 and, length must also be &amp;gt;= (`min_upper` + `min_lower` + `min_numeric` + `min_special`).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Length is required")]
    public required TerraformValue<double> Length
    {
        get => GetRequiredArgument<TerraformValue<double>>("length");
        set => SetArgument("length", value);
    }

    /// <summary>
    /// Include lowercase alphabet characters in the result. Default value is `true`.
    /// </summary>
    public TerraformValue<bool> Lower
    {
        get => GetArgument<TerraformValue<bool>>("lower") ?? CreateReference("lower");
        set => SetArgument("lower", value);
    }

    /// <summary>
    /// Minimum number of lowercase alphabet characters in the result. Default value is `0`.
    /// </summary>
    public TerraformValue<double> MinLower
    {
        get => GetArgument<TerraformValue<double>>("min_lower") ?? CreateReference("min_lower");
        set => SetArgument("min_lower", value);
    }

    /// <summary>
    /// Minimum number of numeric characters in the result. Default value is `0`.
    /// </summary>
    public TerraformValue<double> MinNumeric
    {
        get => GetArgument<TerraformValue<double>>("min_numeric") ?? CreateReference("min_numeric");
        set => SetArgument("min_numeric", value);
    }

    /// <summary>
    /// Minimum number of special characters in the result. Default value is `0`.
    /// </summary>
    public TerraformValue<double> MinSpecial
    {
        get => GetArgument<TerraformValue<double>>("min_special") ?? CreateReference("min_special");
        set => SetArgument("min_special", value);
    }

    /// <summary>
    /// Minimum number of uppercase alphabet characters in the result. Default value is `0`.
    /// </summary>
    public TerraformValue<double> MinUpper
    {
        get => GetArgument<TerraformValue<double>>("min_upper") ?? CreateReference("min_upper");
        set => SetArgument("min_upper", value);
    }

    /// <summary>
    /// Include numeric characters in the result. Default value is `true`. If `number`, `upper`, `lower`, and `special` are all configured, at least one of them must be set to `true`. **NOTE**: This is deprecated, use `numeric` instead.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> Number
    {
        get => GetArgument<TerraformValue<bool>>("number") ?? CreateReference("number");
        set => SetArgument("number", value);
    }

    /// <summary>
    /// Include numeric characters in the result. Default value is `true`. If `numeric`, `upper`, `lower`, and `special` are all configured, at least one of them must be set to `true`.
    /// </summary>
    public TerraformValue<bool> Numeric
    {
        get => GetArgument<TerraformValue<bool>>("numeric") ?? CreateReference("numeric");
        set => SetArgument("numeric", value);
    }

    /// <summary>
    /// Supply your own list of special characters to use for string generation.  This overrides the default character list in the special argument.  The `special` argument must still be set to true for any overwritten characters to be used in generation.
    /// </summary>
    public TerraformValue<string>? OverrideSpecial
    {
        get => GetArgument<TerraformValue<string>>("override_special");
        set => SetArgument("override_special", value);
    }

    /// <summary>
    /// Include special characters in the result. These are `!@#$%&amp;amp;*()-_=+[]{}&amp;lt;&amp;gt;:?`. Default value is `true`.
    /// </summary>
    public TerraformValue<bool> Special
    {
        get => GetArgument<TerraformValue<bool>>("special") ?? CreateReference("special");
        set => SetArgument("special", value);
    }

    /// <summary>
    /// Include uppercase alphabet characters in the result. Default value is `true`.
    /// </summary>
    public TerraformValue<bool> Upper
    {
        get => GetArgument<TerraformValue<bool>>("upper") ?? CreateReference("upper");
        set => SetArgument("upper", value);
    }

    /// <summary>
    /// The generated random string.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The generated random string.
    /// </summary>
    public TerraformValue<string> Result
        => CreateReference("result");

}
