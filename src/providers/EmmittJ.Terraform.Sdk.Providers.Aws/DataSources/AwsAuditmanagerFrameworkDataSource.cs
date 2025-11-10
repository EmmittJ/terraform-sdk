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
        SetOutput("arn");
        SetOutput("compliance_type");
        SetOutput("control_sets");
        SetOutput("description");
        SetOutput("id");
        SetOutput("tags");
        SetOutput("framework_type");
        SetOutput("name");
        SetOutput("region");
    }

    /// <summary>
    /// The framework_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrameworkType is required")]
    public required TerraformProperty<string> FrameworkType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("framework_type");
        set => SetProperty("framework_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
