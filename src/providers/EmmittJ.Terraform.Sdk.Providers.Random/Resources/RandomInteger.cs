using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Random;

/// <summary>
/// Represents a random_integer Terraform resource.
/// The resource `random_integer` generates random values from a given range, described by the `min` and `max` attributes of a given resource.
    /// 
    /// This resource can be used in conjunction with resources that have the `create_before_destroy` lifecycle flag set, to avoid conflicts with unique names during the brief period where both the old and new resources exist concurrently.
/// </summary>
public partial class RandomInteger(string name) : TerraformResource("random_integer", name)
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
    /// The maximum inclusive value of the range.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Max is required")]
    public required TerraformValue<double> Max
    {
        get => GetRequiredArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The minimum inclusive value of the range.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Min is required")]
    public required TerraformValue<double> Min
    {
        get => GetRequiredArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

    /// <summary>
    /// A custom seed to always produce the same value.
    /// </summary>
    public TerraformValue<string>? Seed
    {
        get => GetArgument<TerraformValue<string>>("seed");
        set => SetArgument("seed", value);
    }

    /// <summary>
    /// The string representation of the integer result.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The random integer result.
    /// </summary>
    public TerraformValue<double> Result
        => CreateReference("result");

}
