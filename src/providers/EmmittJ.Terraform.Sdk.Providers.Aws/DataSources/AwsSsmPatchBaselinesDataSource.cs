using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AwsSsmPatchBaselinesDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Retrieves information about a aws_ssm_patch_baselines.
/// </summary>
public class AwsSsmPatchBaselinesDataSource : TerraformDataSource
{
    public AwsSsmPatchBaselinesDataSource(string name) : base("aws_ssm_patch_baselines", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("baseline_identities");
        SetOutput("default_baselines");
        SetOutput("region");
    }

    /// <summary>
    /// The default_baselines attribute.
    /// </summary>
    public TerraformProperty<bool> DefaultBaselines
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("default_baselines");
        set => SetProperty("default_baselines", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSsmPatchBaselinesDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// The baseline_identities attribute.
    /// </summary>
    public TerraformExpression BaselineIdentities => this["baseline_identities"];

}
