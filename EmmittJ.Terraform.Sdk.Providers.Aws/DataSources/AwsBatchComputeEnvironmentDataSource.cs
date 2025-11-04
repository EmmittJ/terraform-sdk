using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_batch_compute_environment.
/// </summary>
public class AwsBatchComputeEnvironmentDataSource : TerraformDataSource
{
    public AwsBatchComputeEnvironmentDataSource(string name) : base("aws_batch_compute_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("ecs_cluster_arn");
        this.DeclareOutput("service_role");
        this.DeclareOutput("state");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
        this.DeclareOutput("type");
        this.DeclareOutput("update_policy");
    }

    /// <summary>
    /// The compute_environment_name attribute.
    /// </summary>
    public string? ComputeEnvironmentName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compute_environment_name")?.Value;
        set => this.WithProperty("compute_environment_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The ecs_cluster_arn attribute.
    /// </summary>
    public TerraformExpression EcsClusterArn => this["ecs_cluster_arn"];

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    public TerraformExpression ServiceRole => this["service_role"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The update_policy attribute.
    /// </summary>
    public TerraformExpression UpdatePolicy => this["update_policy"];

}
