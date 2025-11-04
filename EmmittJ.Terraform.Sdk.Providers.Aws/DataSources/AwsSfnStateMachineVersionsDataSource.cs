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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The statemachine_arn attribute.
    /// </summary>
    public string? StatemachineArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("statemachine_arn")?.Value;
        set => this.WithProperty("statemachine_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The statemachine_versions attribute.
    /// </summary>
    public TerraformExpression StatemachineVersions => this["statemachine_versions"];

}
