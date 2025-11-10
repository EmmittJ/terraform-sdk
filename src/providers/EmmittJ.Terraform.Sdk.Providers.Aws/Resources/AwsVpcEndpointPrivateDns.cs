using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_endpoint_private_dns resource.
/// </summary>
public class AwsVpcEndpointPrivateDns : TerraformResource
{
    public AwsVpcEndpointPrivateDns(string name) : base("aws_vpc_endpoint_private_dns", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("private_dns_enabled");
        SetOutput("region");
        SetOutput("vpc_endpoint_id");
    }

    /// <summary>
    /// The private_dns_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsEnabled is required")]
    public required TerraformProperty<bool> PrivateDnsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("private_dns_enabled");
        set => SetProperty("private_dns_enabled", value);
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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointId is required")]
    public required TerraformProperty<string> VpcEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_endpoint_id");
        set => SetProperty("vpc_endpoint_id", value);
    }

}
