using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshiftserverless_endpoint_access Terraform resource.
/// Manages a aws_redshiftserverless_endpoint_access resource.
/// </summary>
public partial class AwsRedshiftserverlessEndpointAccess(string name) : TerraformResource("aws_redshiftserverless_endpoint_access", name)
{
    /// <summary>
    /// The endpoint_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointName is required")]
    public required TerraformValue<string> EndpointName
    {
        get => GetArgument<TerraformValue<string>>("endpoint_name");
        set => SetArgument("endpoint_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    public TerraformValue<string>? OwnerAccount
    {
        get => GetArgument<TerraformValue<string>>("owner_account");
        set => SetArgument("owner_account", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => GetArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? VpcSecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("vpc_security_group_ids");
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    public required TerraformValue<string> WorkgroupName
    {
        get => GetArgument<TerraformValue<string>>("workgroup_name");
        set => SetArgument("workgroup_name", value);
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformValue<string> Address
        => AsReference("address");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The vpc_endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcEndpoint
        => AsReference("vpc_endpoint");

}
