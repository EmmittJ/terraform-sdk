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
        SetOutput("address");
        SetOutput("arn");
        SetOutput("port");
        SetOutput("vpc_endpoint");
        SetOutput("endpoint_name");
        SetOutput("id");
        SetOutput("owner_account");
        SetOutput("region");
        SetOutput("subnet_ids");
        SetOutput("vpc_security_group_ids");
        SetOutput("workgroup_name");
    }

    /// <summary>
    /// The endpoint_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointName is required")]
    public required TerraformProperty<string> EndpointName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint_name");
        set => SetProperty("endpoint_name", value);
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
    /// The owner_account attribute.
    /// </summary>
    public TerraformProperty<string> OwnerAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("owner_account");
        set => SetProperty("owner_account", value);
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
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>> SubnetIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => SetProperty("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> VpcSecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => SetProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    public required TerraformProperty<string> WorkgroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workgroup_name");
        set => SetProperty("workgroup_name", value);
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
