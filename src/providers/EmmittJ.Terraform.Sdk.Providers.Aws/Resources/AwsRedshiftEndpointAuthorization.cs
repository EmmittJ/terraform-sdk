using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_endpoint_authorization resource.
/// </summary>
public class AwsRedshiftEndpointAuthorization : TerraformResource
{
    public AwsRedshiftEndpointAuthorization(string name) : base("aws_redshift_endpoint_authorization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("allowed_all_vpcs");
        SetOutput("endpoint_count");
        SetOutput("grantee");
        SetOutput("grantor");
        SetOutput("account");
        SetOutput("cluster_identifier");
        SetOutput("force_delete");
        SetOutput("id");
        SetOutput("region");
        SetOutput("vpc_ids");
    }

    /// <summary>
    /// The account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Account is required")]
    public required TerraformProperty<string> Account
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account");
        set => SetProperty("account", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_identifier");
        set => SetProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDelete
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_delete");
        set => SetProperty("force_delete", value);
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
    /// The vpc_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> VpcIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("vpc_ids");
        set => SetProperty("vpc_ids", value);
    }

    /// <summary>
    /// The allowed_all_vpcs attribute.
    /// </summary>
    public TerraformExpression AllowedAllVpcs => this["allowed_all_vpcs"];

    /// <summary>
    /// The endpoint_count attribute.
    /// </summary>
    public TerraformExpression EndpointCount => this["endpoint_count"];

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    public TerraformExpression Grantee => this["grantee"];

    /// <summary>
    /// The grantor attribute.
    /// </summary>
    public TerraformExpression Grantor => this["grantor"];

}
