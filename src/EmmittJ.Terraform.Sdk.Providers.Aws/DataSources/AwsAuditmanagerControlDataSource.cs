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
        this.DeclareOutput("action_plan_instructions");
        this.DeclareOutput("action_plan_title");
        this.DeclareOutput("arn");
        this.DeclareOutput("control_mapping_sources");
        this.DeclareOutput("description");
        this.DeclareOutput("id");
        this.DeclareOutput("tags");
        this.DeclareOutput("testing_information");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
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
