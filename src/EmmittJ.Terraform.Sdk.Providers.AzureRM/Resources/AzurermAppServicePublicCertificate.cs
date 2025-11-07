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
    public TerraformLiteralProperty<string>? AppServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_service_name");
        set => this.WithProperty("app_service_name", value);
    }

    /// <summary>
    /// The blob attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Blob
    {
        get => GetProperty<TerraformLiteralProperty<string>>("blob");
        set => this.WithProperty("blob", value);
    }

    /// <summary>
    /// The certificate_location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CertificateLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_location");
        set => this.WithProperty("certificate_location", value);
    }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CertificateName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_name");
        set => this.WithProperty("certificate_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

}
