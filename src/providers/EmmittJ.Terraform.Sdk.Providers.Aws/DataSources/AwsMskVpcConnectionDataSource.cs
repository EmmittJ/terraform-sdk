using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_msk_vpc_connection.
/// </summary>
public class AwsMskVpcConnectionDataSource : TerraformDataSource
{
    public AwsMskVpcConnectionDataSource(string name) : base("aws_msk_vpc_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("authentication");
        SetOutput("client_subnets");
        SetOutput("security_groups");
        SetOutput("target_cluster_arn");
        SetOutput("vpc_id");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    public TerraformExpression Authentication => this["authentication"];

    /// <summary>
    /// The client_subnets attribute.
    /// </summary>
    public TerraformExpression ClientSubnets => this["client_subnets"];

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformExpression SecurityGroups => this["security_groups"];

    /// <summary>
    /// The target_cluster_arn attribute.
    /// </summary>
    public TerraformExpression TargetClusterArn => this["target_cluster_arn"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
