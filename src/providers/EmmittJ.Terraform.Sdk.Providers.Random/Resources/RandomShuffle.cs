using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Random;

/// <summary>
/// Represents a random_shuffle Terraform resource.
/// The resource `random_shuffle` generates a random permutation of a list of strings given as an argument.
/// </summary>
public partial class RandomShuffle(string name) : TerraformResource("random_shuffle", name)
{
    /// <summary>
    /// The list of strings to shuffle.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Input is required")]
    public TerraformList<string>? Input
    {
        get => GetArgument<TerraformList<string>>("input");
        set => SetArgument("input", value);
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
    /// The number of results to return. Defaults to the number of items in the `input` list. If fewer items are requested, some elements will be excluded from the result. If more items are requested, items will be repeated in the result but not more frequently than the number of items in the input list.
    /// </summary>
    public TerraformValue<double>? ResultCount
    {
        get => GetArgument<TerraformValue<double>>("result_count");
        set => SetArgument("result_count", value);
    }

    /// <summary>
    /// Arbitrary string with which to seed the random number generator, in order to produce less-volatile permutations of the list.
    /// 
    /// **Important:** Even with an identical seed, it is not guaranteed that the same permutation will be produced across different versions of Terraform. This argument causes the result to be *less volatile*, but not fixed for all time.
    /// </summary>
    public TerraformValue<string>? Seed
    {
        get => GetArgument<TerraformValue<string>>("seed");
        set => SetArgument("seed", value);
    }

    /// <summary>
    /// A static value used internally by Terraform, this should not be referenced in configurations.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// Random permutation of the list of strings given in `input`. The number of elements is determined by `result_count` if set, or the number of elements in `input`.
    /// </summary>
    public TerraformList<string> Result
        => CreateReference("result");

}
