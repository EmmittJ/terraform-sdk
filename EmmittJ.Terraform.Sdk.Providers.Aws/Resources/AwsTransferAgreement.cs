using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_agreement resource.
/// </summary>
public class AwsTransferAgreement : TerraformResource
{
    public AwsTransferAgreement(string name) : base("aws_transfer_agreement", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("agreement_id");
        this.DeclareOutput("arn");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The access_role attribute.
    /// </summary>
    public string? AccessRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_role")?.Value;
        set => this.WithProperty("access_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The base_directory attribute.
    /// </summary>
    public string? BaseDirectory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("base_directory")?.Value;
        set => this.WithProperty("base_directory", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_profile_id attribute.
    /// </summary>
    public string? LocalProfileId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_profile_id")?.Value;
        set => this.WithProperty("local_profile_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The partner_profile_id attribute.
    /// </summary>
    public string? PartnerProfileId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("partner_profile_id")?.Value;
        set => this.WithProperty("partner_profile_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    public string? ServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_id")?.Value;
        set => this.WithProperty("server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The agreement_id attribute.
    /// </summary>
    public TerraformExpression AgreementId => this["agreement_id"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
