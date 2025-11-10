using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3outposts_endpoint resource.
/// </summary>
public class AwsS3outpostsEndpoint : TerraformResource
{
    public AwsS3outpostsEndpoint(string name) : base("aws_s3outposts_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("cidr_block");
        SetOutput("creation_time");
        SetOutput("network_interfaces");
        SetOutput("access_type");
        SetOutput("customer_owned_ipv4_pool");
        SetOutput("id");
        SetOutput("outpost_id");
        SetOutput("region");
        SetOutput("security_group_id");
        SetOutput("subnet_id");
    }

    /// <summary>
    /// The access_type attribute.
    /// </summary>
    public TerraformProperty<string> AccessType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_type");
        set => SetProperty("access_type", value);
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformProperty<string> CustomerOwnedIpv4Pool
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_owned_ipv4_pool");
        set => SetProperty("customer_owned_ipv4_pool", value);
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
    /// The outpost_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutpostId is required")]
    public required TerraformProperty<string> OutpostId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("outpost_id");
        set => SetProperty("outpost_id", value);
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
    /// The security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupId is required")]
    public required TerraformProperty<string> SecurityGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_group_id");
        set => SetProperty("security_group_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformExpression CidrBlock => this["cidr_block"];

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The network_interfaces attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaces => this["network_interfaces"];

}
