using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_securityhub_standards_control_associations.
/// </summary>
public class AwsSecurityhubStandardsControlAssociationsDataSource : TerraformDataSource
{
    public AwsSecurityhubStandardsControlAssociationsDataSource(string name) : base("aws_securityhub_standards_control_associations", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("standards_control_associations");
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
    /// The security_control_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityControlId is required")]
    public required TerraformProperty<string> SecurityControlId
    {
        get => GetProperty<TerraformProperty<string>>("security_control_id");
        set => this.WithProperty("security_control_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The standards_control_associations attribute.
    /// </summary>
    public TerraformExpression StandardsControlAssociations => this["standards_control_associations"];

}
