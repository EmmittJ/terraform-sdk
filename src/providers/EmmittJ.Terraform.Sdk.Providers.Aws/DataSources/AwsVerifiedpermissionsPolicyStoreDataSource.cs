using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_verifiedpermissions_policy_store.
/// </summary>
public class AwsVerifiedpermissionsPolicyStoreDataSource : TerraformDataSource
{
    public AwsVerifiedpermissionsPolicyStoreDataSource(string name) : base("aws_verifiedpermissions_policy_store", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("created_date");
        this.WithOutput("deletion_protection");
        this.WithOutput("description");
        this.WithOutput("last_updated_date");
        this.WithOutput("tags");
        this.WithOutput("validation_settings");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformExpression DeletionProtection => this["deletion_protection"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformExpression LastUpdatedDate => this["last_updated_date"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The validation_settings attribute.
    /// </summary>
    public TerraformExpression ValidationSettings => this["validation_settings"];

}
