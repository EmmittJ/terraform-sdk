using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_endpoint_authorization Terraform resource.
/// Manages a aws_redshift_endpoint_authorization resource.
/// </summary>
public partial class AwsRedshiftEndpointAuthorization(string name) : TerraformResource("aws_redshift_endpoint_authorization", name)
{
    /// <summary>
    /// The account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Account is required")]
    public required TerraformValue<string> Account
    {
        get => GetArgument<TerraformValue<string>>("account");
        set => SetArgument("account", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDelete
    {
        get => GetArgument<TerraformValue<bool>>("force_delete");
        set => SetArgument("force_delete", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The vpc_ids attribute.
    /// </summary>
    public TerraformSet<string>? VpcIds
    {
        get => GetArgument<TerraformSet<string>>("vpc_ids");
        set => SetArgument("vpc_ids", value);
    }

    /// <summary>
    /// The allowed_all_vpcs attribute.
    /// </summary>
    public TerraformValue<bool> AllowedAllVpcs
        => AsReference("allowed_all_vpcs");

    /// <summary>
    /// The endpoint_count attribute.
    /// </summary>
    public TerraformValue<double> EndpointCount
        => AsReference("endpoint_count");

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    public TerraformValue<string> Grantee
        => AsReference("grantee");

    /// <summary>
    /// The grantor attribute.
    /// </summary>
    public TerraformValue<string> Grantor
        => AsReference("grantor");

}
