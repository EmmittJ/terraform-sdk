using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshiftserverless_endpoint_access resource.
/// </summary>
public class AwsRedshiftserverlessEndpointAccess : TerraformResource
{
    public AwsRedshiftserverlessEndpointAccess(string name) : base("aws_redshiftserverless_endpoint_access", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("address");
        this.DeclareOutput("arn");
        this.DeclareOutput("port");
        this.DeclareOutput("vpc_endpoint");
    }

    /// <summary>
    /// The endpoint_name attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointName
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_name");
        set => this.WithProperty("endpoint_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    public TerraformProperty<string>? OwnerAccount
    {
        get => GetProperty<TerraformProperty<string>>("owner_account");
        set => this.WithProperty("owner_account", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SubnetIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    public TerraformProperty<string>? WorkgroupName
    {
        get => GetProperty<TerraformProperty<string>>("workgroup_name");
        set => this.WithProperty("workgroup_name", value);
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformExpression Address => this["address"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The vpc_endpoint attribute.
    /// </summary>
    public TerraformExpression VpcEndpoint => this["vpc_endpoint"];

}
