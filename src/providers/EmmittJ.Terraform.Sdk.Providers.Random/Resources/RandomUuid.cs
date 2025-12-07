using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Random;

/// <summary>
/// Represents a random_uuid Terraform resource.
/// The resource `random_uuid` generates a random uuid string that is intended to be used as a unique identifier for other resources.
    /// 
    /// This resource uses [hashicorp/go-uuid](https://github.com/hashicorp/go-uuid) to generate a UUID-formatted string for use with services needing a unique string identifier.
/// </summary>
public partial class RandomUuid(string name) : TerraformResource("random_uuid", name)
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
    /// The generated uuid presented in string format.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The generated uuid presented in string format.
    /// </summary>
    public TerraformValue<string> Result
        => CreateReference("result");

}
