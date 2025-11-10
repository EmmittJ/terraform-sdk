using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lakeformation_resource.
/// </summary>
public class AwsLakeformationResourceDataSource : TerraformDataSource
{
    public AwsLakeformationResourceDataSource(string name) : base("aws_lakeformation_resource", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("hybrid_access_enabled");
        this.DeclareOutput("last_modified");
        this.DeclareOutput("role_arn");
        this.DeclareOutput("with_federation");
        this.DeclareOutput("with_privileged_access");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
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
    /// The hybrid_access_enabled attribute.
    /// </summary>
    public TerraformExpression HybridAccessEnabled => this["hybrid_access_enabled"];

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformExpression RoleArn => this["role_arn"];

    /// <summary>
    /// The with_federation attribute.
    /// </summary>
    public TerraformExpression WithFederation => this["with_federation"];

    /// <summary>
    /// The with_privileged_access attribute.
    /// </summary>
    public TerraformExpression WithPrivilegedAccess => this["with_privileged_access"];

}
