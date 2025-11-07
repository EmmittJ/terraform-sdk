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
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_arn");
        set => this.WithProperty("cluster_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecretArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_arn");
        set => this.WithProperty("secret_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
