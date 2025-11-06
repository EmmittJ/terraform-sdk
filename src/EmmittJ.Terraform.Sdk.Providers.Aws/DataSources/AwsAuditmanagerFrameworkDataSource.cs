using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_auditmanager_framework.
/// </summary>
public class AwsAuditmanagerFrameworkDataSource : TerraformDataSource
{
    public AwsAuditmanagerFrameworkDataSource(string name) : base("aws_auditmanager_framework", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("compliance_type");
        this.DeclareOutput("control_sets");
        this.DeclareOutput("description");
        this.DeclareOutput("id");
        this.DeclareOutput("tags");
    }

    /// <summary>
    /// The framework_type attribute.
    /// </summary>
    public string? FrameworkType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("framework_type")?.Value;
        set => this.WithProperty("framework_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The compliance_type attribute.
    /// </summary>
    public TerraformExpression ComplianceType => this["compliance_type"];

    /// <summary>
    /// The control_sets attribute.
    /// </summary>
    public TerraformExpression ControlSets => this["control_sets"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
