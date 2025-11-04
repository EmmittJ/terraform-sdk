using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_load_balancer_policy resource.
/// </summary>
public class AwsLoadBalancerPolicy : TerraformResource
{
    public AwsLoadBalancerPolicy(string name) : base("aws_load_balancer_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The load_balancer_name attribute.
    /// </summary>
    public string? LoadBalancerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancer_name")?.Value;
        set => this.WithProperty("load_balancer_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    public string? PolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_name")?.Value;
        set => this.WithProperty("policy_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_type_name attribute.
    /// </summary>
    public string? PolicyTypeName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_type_name")?.Value;
        set => this.WithProperty("policy_type_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
