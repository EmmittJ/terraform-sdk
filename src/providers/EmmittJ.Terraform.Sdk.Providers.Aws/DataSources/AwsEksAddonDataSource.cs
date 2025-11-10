using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eks_addon.
/// </summary>
public class AwsEksAddonDataSource : TerraformDataSource
{
    public AwsEksAddonDataSource(string name) : base("aws_eks_addon", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("addon_version");
        SetOutput("arn");
        SetOutput("configuration_values");
        SetOutput("created_at");
        SetOutput("modified_at");
        SetOutput("pod_identity_association");
        SetOutput("service_account_role_arn");
        SetOutput("addon_name");
        SetOutput("cluster_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The addon_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddonName is required")]
    public required TerraformProperty<string> AddonName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("addon_name");
        set => SetProperty("addon_name", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_name");
        set => SetProperty("cluster_name", value);
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
    /// The addon_version attribute.
    /// </summary>
    public TerraformExpression AddonVersion => this["addon_version"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The configuration_values attribute.
    /// </summary>
    public TerraformExpression ConfigurationValues => this["configuration_values"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    public TerraformExpression ModifiedAt => this["modified_at"];

    /// <summary>
    /// The pod_identity_association attribute.
    /// </summary>
    public TerraformExpression PodIdentityAssociation => this["pod_identity_association"];

    /// <summary>
    /// The service_account_role_arn attribute.
    /// </summary>
    public TerraformExpression ServiceAccountRoleArn => this["service_account_role_arn"];

}
