using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for validation_settings in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsPolicyStoreValidationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        set => SetProperty("mode", value);
    }

}

/// <summary>
/// Manages a aws_verifiedpermissions_policy_store resource.
/// </summary>
public class AwsVerifiedpermissionsPolicyStore : TerraformResource
{
    public AwsVerifiedpermissionsPolicyStore(string name) : base("aws_verifiedpermissions_policy_store", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("id");
        SetOutput("policy_store_id");
        SetOutput("tags_all");
        SetOutput("deletion_protection");
        SetOutput("description");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformProperty<string> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for validation_settings.
    /// Nesting mode: list
    /// </summary>
    public List<AwsVerifiedpermissionsPolicyStoreValidationSettingsBlock>? ValidationSettings
    {
        set => SetProperty("validation_settings", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    public TerraformExpression PolicyStoreId => this["policy_store_id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
