using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_app_service_public_certificate resource.
/// </summary>
public class AzurermAppServicePublicCertificate : TerraformResource
{
    public AzurermAppServicePublicCertificate(string name) : base("azurerm_app_service_public_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("thumbprint");
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    public string? AppServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_service_name")?.Value;
        set => this.WithProperty("app_service_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The blob attribute.
    /// </summary>
    public string? Blob
    {
        get => GetProperty<TerraformLiteralProperty<string>>("blob")?.Value;
        set => this.WithProperty("blob", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_location attribute.
    /// </summary>
    public string? CertificateLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_location")?.Value;
        set => this.WithProperty("certificate_location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    public string? CertificateName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_name")?.Value;
        set => this.WithProperty("certificate_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

}
