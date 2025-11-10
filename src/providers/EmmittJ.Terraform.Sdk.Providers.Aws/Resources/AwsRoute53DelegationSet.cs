using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_delegation_set resource.
/// </summary>
public class AwsRoute53DelegationSet : TerraformResource
{
    public AwsRoute53DelegationSet(string name) : base("aws_route53_delegation_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("name_servers");
        SetOutput("id");
        SetOutput("reference_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The reference_name attribute.
    /// </summary>
    public TerraformProperty<string> ReferenceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("reference_name");
        set => SetProperty("reference_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    public TerraformExpression NameServers => this["name_servers"];

}
