using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sfn_state_machine_versions.
/// </summary>
public class AwsSfnStateMachineVersionsDataSource : TerraformDataSource
{
    public AwsSfnStateMachineVersionsDataSource(string name) : base("aws_sfn_state_machine_versions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("statemachine_versions");
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
    /// The statemachine_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatemachineArn is required")]
    public required TerraformProperty<string> StatemachineArn
    {
        get => GetProperty<TerraformProperty<string>>("statemachine_arn");
        set => this.WithProperty("statemachine_arn", value);
    }

    /// <summary>
    /// The statemachine_versions attribute.
    /// </summary>
    public TerraformExpression StatemachineVersions => this["statemachine_versions"];

}
