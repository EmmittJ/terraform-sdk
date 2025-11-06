using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagentcore_workload_identity resource.
/// </summary>
public class AwsBedrockagentcoreWorkloadIdentity : TerraformResource
{
    public AwsBedrockagentcoreWorkloadIdentity(string name) : base("aws_bedrockagentcore_workload_identity", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("workload_identity_arn");
    }

    /// <summary>
    /// The allowed_resource_oauth2_return_urls attribute.
    /// </summary>
    public HashSet<string>? AllowedResourceOauth2ReturnUrls
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("allowed_resource_oauth2_return_urls")?.Value;
        set => this.WithProperty("allowed_resource_oauth2_return_urls", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The workload_identity_arn attribute.
    /// </summary>
    public TerraformExpression WorkloadIdentityArn => this["workload_identity_arn"];

}
