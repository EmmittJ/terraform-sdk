using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_servicecatalog_launch_paths.
/// </summary>
public class AwsServicecatalogLaunchPathsDataSource : TerraformDataSource
{
    public AwsServicecatalogLaunchPathsDataSource(string name) : base("aws_servicecatalog_launch_paths", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("summaries");
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    public string? AcceptLanguage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("accept_language")?.Value;
        set => this.WithProperty("accept_language", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The product_id attribute.
    /// </summary>
    public string? ProductId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("product_id")?.Value;
        set => this.WithProperty("product_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The summaries attribute.
    /// </summary>
    public TerraformExpression Summaries => this["summaries"];

}
