using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_endpoint_service_allowed_principal resource.
/// </summary>
public class AwsVpcEndpointServiceAllowedPrincipal : TerraformResource
{
    public AwsVpcEndpointServiceAllowedPrincipal(string name) : base("aws_vpc_endpoint_service_allowed_principal", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("principal_arn");
        SetOutput("region");
        SetOutput("vpc_endpoint_service_id");
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
    /// The principal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalArn is required")]
    public required TerraformProperty<string> PrincipalArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal_arn");
        set => SetProperty("principal_arn", value);
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
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointServiceId is required")]
    public required TerraformProperty<string> VpcEndpointServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_endpoint_service_id");
        set => SetProperty("vpc_endpoint_service_id", value);
    }

}
