using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_auditmanager_control.
/// </summary>
public class AwsAuditmanagerControlDataSource : TerraformDataSource
{
    public AwsAuditmanagerControlDataSource(string name) : base("aws_auditmanager_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("action_plan_instructions");
        this.WithOutput("action_plan_title");
        this.WithOutput("arn");
        this.WithOutput("control_mapping_sources");
        this.WithOutput("description");
        this.WithOutput("id");
        this.WithOutput("tags");
        this.WithOutput("testing_information");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The action_plan_instructions attribute.
    /// </summary>
    public TerraformExpression ActionPlanInstructions => this["action_plan_instructions"];

    /// <summary>
    /// The action_plan_title attribute.
    /// </summary>
    public TerraformExpression ActionPlanTitle => this["action_plan_title"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The control_mapping_sources attribute.
    /// </summary>
    public TerraformExpression ControlMappingSources => this["control_mapping_sources"];

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

    /// <summary>
    /// The testing_information attribute.
    /// </summary>
    public TerraformExpression TestingInformation => this["testing_information"];

}
