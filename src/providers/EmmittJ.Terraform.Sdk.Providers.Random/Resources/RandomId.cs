using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Random;

/// <summary>
/// Represents a random_id Terraform resource.
/// 
    /// The resource `random_id` generates random numbers that are intended to be
    /// used as unique identifiers for other resources. If the output is considered 
    /// sensitive, and should not be displayed in the CLI, use `random_bytes`
    /// instead.
    /// 
    /// This resource *does* use a cryptographic random number generator in order
    /// to minimize the chance of collisions, making the results of this resource
    /// when a 16-byte identifier is requested of equivalent uniqueness to a
    /// type-4 UUID.
    /// 
    /// This resource can be used in conjunction with resources that have
    /// the `create_before_destroy` lifecycle flag set to avoid conflicts with
    /// unique names during the brief period where both the old and new resources
    /// exist concurrently.
    /// 
/// </summary>
public partial class RandomId(string name) : TerraformResource("random_id", name)
{
    /// <summary>
    /// The number of random bytes to produce. The minimum value is 1, which produces eight bits of randomness.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ByteLength is required")]
    public required TerraformValue<double> ByteLength
    {
        get => GetRequiredArgument<TerraformValue<double>>("byte_length");
        set => SetArgument("byte_length", value);
    }

    /// <summary>
    /// Arbitrary map of values that, when changed, will trigger recreation of resource. See [the main provider documentation](../index.html) for more information.
    /// </summary>
    public TerraformMap<string>? Keepers
    {
        get => GetArgument<TerraformMap<string>>("keepers");
        set => SetArgument("keepers", value);
    }

    /// <summary>
    /// Arbitrary string to prefix the output value with. This string is supplied as-is, meaning it is not guaranteed to be URL-safe or base64 encoded.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The generated id presented in base64 without additional transformations.
    /// </summary>
    public TerraformValue<string> B64Std
        => CreateReference("b64_std");

    /// <summary>
    /// The generated id presented in base64, using the URL-friendly character set: case-sensitive letters, digits and the characters `_` and `-`.
    /// </summary>
    public TerraformValue<string> B64Url
        => CreateReference("b64_url");

    /// <summary>
    /// The generated id presented in non-padded decimal digits.
    /// </summary>
    public TerraformValue<string> Dec
        => CreateReference("dec");

    /// <summary>
    /// The generated id presented in padded hexadecimal digits. This result will always be twice as long as the requested byte length.
    /// </summary>
    public TerraformValue<string> Hex
        => CreateReference("hex");

    /// <summary>
    /// The generated id presented in base64 without additional transformations or prefix.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

}
