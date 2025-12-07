using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Random;

/// <summary>
/// Represents a random_pet Terraform resource.
/// The resource `random_pet` generates random pet names that are intended to be used as unique identifiers for other resources.
    /// 
    /// This resource can be used in conjunction with resources that have the `create_before_destroy` lifecycle flag set, to avoid conflicts with unique names during the brief period where both the old and new resources exist concurrently.
/// </summary>
public partial class RandomPet(string name) : TerraformResource("random_pet", name)
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
    /// The length (in words) of the pet name. Defaults to 2
    /// </summary>
    public TerraformValue<double> Length
    {
        get => GetArgument<TerraformValue<double>>("length") ?? CreateReference("length");
        set => SetArgument("length", value);
    }

    /// <summary>
    /// A string to prefix the name with.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The character to separate words in the pet name. Defaults to &amp;quot;-&amp;quot;
    /// </summary>
    public TerraformValue<string> Separator
    {
        get => GetArgument<TerraformValue<string>>("separator") ?? CreateReference("separator");
        set => SetArgument("separator", value);
    }

    /// <summary>
    /// The random pet name.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

}
