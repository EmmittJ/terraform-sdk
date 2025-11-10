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
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("policy_store_id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformProperty<string>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<string>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for validation_settings.
    /// Nesting mode: list
    /// </summary>
    public List<AwsVerifiedpermissionsPolicyStoreValidationSettingsBlock>? ValidationSettings
    {
        get => GetProperty<List<AwsVerifiedpermissionsPolicyStoreValidationSettingsBlock>>("validation_settings");
        set => this.WithProperty("validation_settings", value);
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
