using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_msk_single_scram_secret_association resource.
/// </summary>
public class AwsMskSingleScramSecretAssociation : TerraformResource
{
    public AwsMskSingleScramSecretAssociation(string name) : base("aws_msk_single_scram_secret_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("id");
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    public required TerraformProperty<string> ClusterArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_arn");
        set => this.WithProperty("cluster_arn", value);
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
    /// The secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretArn is required")]
    public required TerraformProperty<string> SecretArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("secret_arn");
        set => this.WithProperty("secret_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
