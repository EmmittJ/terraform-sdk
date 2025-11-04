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
    /// The security_control_id attribute.
    /// </summary>
    public string? SecurityControlId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_control_id")?.Value;
        set => this.WithProperty("security_control_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
