using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_prometheus_resource_policy resource.
/// </summary>
public class AwsPrometheusResourcePolicy : TerraformResource
{
    public AwsPrometheusResourcePolicy(string name) : base("aws_prometheus_resource_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    public string? PolicyDocument
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_document")?.Value;
        set => this.WithProperty("policy_document", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The revision_id attribute.
    /// </summary>
    public string? RevisionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("revision_id")?.Value;
        set => this.WithProperty("revision_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
