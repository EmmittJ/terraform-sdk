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
    public string? ClusterArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_arn")?.Value;
        set => this.WithProperty("cluster_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public string? SecretArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_arn")?.Value;
        set => this.WithProperty("secret_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
