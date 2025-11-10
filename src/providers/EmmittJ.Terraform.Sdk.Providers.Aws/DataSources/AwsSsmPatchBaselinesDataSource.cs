using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AwsSsmPatchBaselinesDataSourceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ssm_patch_baselines.
/// </summary>
public class AwsSsmPatchBaselinesDataSource : TerraformDataSource
{
    public AwsSsmPatchBaselinesDataSource(string name) : base("aws_ssm_patch_baselines", name)
    {
    }

    /// <summary>
    /// The default_baselines attribute.
    /// </summary>
    [TerraformPropertyName("default_baselines")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DefaultBaselines { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformList<TerraformBlock<AwsSsmPatchBaselinesDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// The baseline_identities attribute.
    /// </summary>
    [TerraformPropertyName("baseline_identities")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BaselineIdentities => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "baseline_identities");

}
